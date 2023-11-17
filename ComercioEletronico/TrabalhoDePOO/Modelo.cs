using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal class Modelo
    {
        /// <summary>
        /// Atributos Class Modelo
        /// </summary>
        public int idModelo { get; set; }
        public string nameModelo { get; set; }
        public string descricao { get; set; }
        public Marca marca { get; set; }
        public DateTime dataFabrico { get; set; }

        /// <summary>
        /// Construtor Class Modelo
        /// </summary>
        public Modelo() { }
        public Modelo(int idModelo, string nameModelo, string descricao, Marca marca, DateTime dataFabrico) 
        {
            this.idModelo = idModelo;
            this.nameModelo = nameModelo;
            this.descricao = descricao;
            this.marca = marca;
            this.dataFabrico = dataFabrico;
        }

        /// <summary>
        /// Metodos Class Marca
        /// </summary>

        public List<Modelo> CarregarDados(string FilePath)
        {
            List<Modelo> modelos = new List<Modelo>();
            if (File.Exists(FilePath))
            {

                using (var reader = new StreamReader(FilePath))
                {
                    using (var csv = new CsvReader(reader,
                        new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        //var loadedRecords = csv.GetRecords<Person>().ToList();
                        modelos = csv.GetRecords<Modelo>().ToList();

                    }
                }
            }
            return modelos;

        }
        public int GuardarDados(string FilePath, List<Modelo> modelo)
        {
            try
            {
                // Serialização para CSV
                using (var writer = new StreamWriter(FilePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(modelo);
                }
                return 1;
            }
            catch { return 0; }
        }
        public void AdicionarModelo(List<Modelo> modelos, List<Marca> marcas)
        {
            Console.WriteLine("\nAdicionar modelo:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Descrição: ");
            string descr = Console.ReadLine();
            Console.WriteLine("Selecione a modelo (id):");
            foreach (Marca marca in marcas)
            {
                Console.WriteLine($"{marca.idMarca} - {marca.nomeMarca} ");
            }
            bool inOut = true;
            int index = -1;
            while (inOut)
            {
                Console.Write("=>");
                int idMarca = int.Parse(Console.ReadLine());
                inOut = marcas.Exists(marca => marca.idMarca.Equals(idMarca));
                if (inOut == true) 
                { 
                    index = marcas.FindIndex(marca => marca.idMarca.Equals(idMarca)); 
                    inOut = false; 
                }
                else { Console.WriteLine("Marca não encontada."); }
            }
            Console.Write("Data de Fabrico:");
            DateTime dataFabrico = DateTime.Parse(Console.ReadLine());

            // Obtém o último índice registrado na lista
            int id = modelos.Count > 0 ? modelos.Count + 1 : 1;
            Modelo modelo = new Modelo(id, nome, descr, marcas[index], dataFabrico);

            // Adiciona a marca à lista
            modelos.Add(modelo);

            Console.WriteLine("\nModelo adicionado com sucesso. ID do modelo: " + id);
            Console.WriteLine("\n");
        }
        public void ListarModelo(List<Modelo> modelos)
        {
            Console.WriteLine("\nLista de Modelos:");
            int i = -1;
            foreach (Modelo modelo in modelos)
            {
                i++;
                Console.WriteLine($"\nId Modelo: {modelo.idModelo} " +
                    $"\nNome: {modelo.nameModelo}" +
                    $"\nDescrição: {modelo.descricao}" +
                    $"\nMarca:{modelo.marca.nomeMarca}" +
                    $"\nData de Fabrico:{modelo.dataFabrico}");
            }
            Console.WriteLine("\n");
        }
        public void EditarModelo(List<Modelo> modelos, List<Marca> marcas)
        {
            Console.WriteLine("\nEditar Marca:");
            Console.Write("Id da Marca a ser editada: ");
            int id = int.Parse(Console.ReadLine());
            int index = modelos.FindIndex(modelo => modelo.idModelo.Equals(id));

            if (index >= 0)
            {
                Console.Write("Novo Nome: ");
                modelos[index].nameModelo = Console.ReadLine();
                Console.Write("Descrição: ");
                modelos[index].descricao = Console.ReadLine();
                Console.WriteLine("Selecione a Marca (id):");
                foreach (Marca marca in marcas)
                {
                    Console.WriteLine($"{marca.idMarca} - {marca.nomeMarca} ");
                }
                bool inOut = true;
                int indexMarca = -1;
                while (inOut)
                {
                    Console.Write("=>");
                    int idMarca = int.Parse(Console.ReadLine());
                    inOut = marcas.Exists(marca => marca.idMarca.Equals(idMarca));
                    if (inOut == true) { Console.WriteLine("Marca não encontada."); }
                    else { indexMarca = marcas.FindIndex(marca => marca.idMarca.Equals(idMarca)); }
                }
                modelos[index].marca = marcas[indexMarca];
                modelos[index].dataFabrico = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Marca editada com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Marca editada.");
            }
            Console.WriteLine("\n");
        }
        public void RemoverModelo(List<Modelo> modelos)
        {
            Console.WriteLine("\nRemover Pessoa:");
            Console.Write("Id do modelo a ser excluída: ");
            int id = int.Parse(Console.ReadLine());
            int index = modelos.FindIndex(modelo => modelo.idModelo.Equals(id));

            if (index >= 0)
            {
                modelos.RemoveAt(index);
                Console.WriteLine("Modelo excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma modelo excluído.");
            }
            Console.WriteLine("\n");
        }

    }
}
