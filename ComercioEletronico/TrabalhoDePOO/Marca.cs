using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TrabalhoDePOO
{
    internal class Marca
    {
        /// <summary>
        /// Atributos Class Marca
        /// </summary>
        public int idMarca { get; set; }
        public string nomeMarca { get; set;}

        /// <summary>
        /// Construtor Class Marca
        /// </summary>
        public Marca() { }
        public Marca(int idMarca, string nomeMarca) 
        {  
            this.idMarca = idMarca;
            this.nomeMarca = nomeMarca;
        }

        /// <summary>
        /// Metodos Class Marca
        /// </summary>

        public List<Marca> CarregarDados(string FilePath)
        {
            List<Marca> marcas = new List<Marca>();
            if (File.Exists(FilePath))
            {

                using (var reader = new StreamReader(FilePath))
                {
                    using (var csv = new CsvReader(reader,
                        new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        //var loadedRecords = csv.GetRecords<Person>().ToList();
                        marcas = csv.GetRecords<Marca>().ToList();

                    }
                }
            }
            return marcas;

        }
        public int GuardarDados(string FilePath, List<Marca> marcas)
        {
            try
            {
                // Serialização para CSV
                using (var writer = new StreamWriter(FilePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(marcas);
                }
                return 1;
            }
            catch { return 0; }
        }
        public void AdicionarMarca(List<Marca> marcas)
        {
            Console.WriteLine("\nAdicionar Marca:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            // Obtém o último índice registrado na lista
            int id = marcas.Count > 0 ? marcas.Count + 1 : 1;
            Marca marca = new Marca(id, nome);

            // Adiciona a marca à lista
            marcas.Add(marca);

            Console.WriteLine("\nMarca adicionada com sucesso. ID da marca: " + id);
            Console.WriteLine("\n");
        }
        public void ListarMarca(List<Marca> marcas)
        {
            Console.WriteLine("\nLista de Marcas:");
            int i = -1;
            foreach (Marca marca in marcas)
            {
                i++;
                Console.WriteLine($"IdMarca:{marca.idMarca} Nome: {marca.nomeMarca}");
            }
            Console.WriteLine("\n");
        }
        public void EditarMarca(List<Marca> marcas)
        {
            Console.WriteLine("\nEditar Marca:");
            Console.Write("Id da Marca a ser editada: ");
            int id = int.Parse(Console.ReadLine());
            int index = marcas.FindIndex(marca => marca.idMarca.Equals(id));

            if (index >= 0)
            {
                Console.Write("Novo Nome: ");
                string nome = Console.ReadLine();
                marcas[index].nomeMarca = nome;
                Console.WriteLine("Marca editada com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Marca editada.");
            }
            Console.WriteLine("\n");
        }
        public void RemoverMarca(List<Marca> marcas)
        {
            Console.WriteLine("\nRemover Pessoa:");
            Console.Write("Id da Marca a ser excluída: ");
            int id = int.Parse(Console.ReadLine());
            int index = marcas.FindIndex(marca => marca.idMarca.Equals(id));

            if (index >= 0)
            {
                marcas.RemoveAt(index);
                Console.WriteLine("Marca excluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Marca excluída.");
            }
            Console.WriteLine("\n");
        }

    }
}
