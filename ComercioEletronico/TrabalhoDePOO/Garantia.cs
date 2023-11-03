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
    internal class Garantia
    {

        /// <summary>
        /// Atributos Class Garantia
        /// </summary>
        public int idGarantia { get; set; }
        public string desc { get; set; }


        /// <summary>
        /// Cosntrutor Class Garantia
        /// </summary>{
        
        public Garantia() { }

        public Garantia(int idGarantia, string desc)
        {
            this.idGarantia = idGarantia;
            this.desc = desc;
        }
        public List<Garantia> CarregarDados(string FilePath)
        {
            List<Garantia> Garantias = new List<Garantia>();
            if (File.Exists(FilePath))
            {

                using (var reader = new StreamReader(FilePath))
                {
                    using (var csv = new CsvReader(reader,
                        new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        //var loadedRecords = csv.GetRecords<Person>().ToList();
                        Garantias = csv.GetRecords<Garantia>().ToList();

                    }
                }
            }
            return Garantias;

        }
        public int GuardarDados(string FilePath, List<Garantia> Garantia)
        {
            try
            {
                // Serialização para CSV
                using (var writer = new StreamWriter(FilePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(Garantia);
                }
                return 1;
            }
            catch { return 0; }
        }
        //public void AdicionarGarantia(List<Garantia> Garantias, List<Marca> marcas)
        //{
        //    Console.WriteLine("\nAdicionar Garantia:");
        //    Console.Write("Nome: ");
        //    string nome = Console.ReadLine();
        //    Console.Write("Descrição: ");
        //    string descr = Console.ReadLine();
        //    Console.WriteLine("Selecione a Garantia (id):");
        //    foreach (Marca marca in marcas)
        //    {
        //        Console.WriteLine($"{marca.idMarca} - {marca.nomeMarca} ");
        //    }
        //    bool inOut = true;
        //    int index = -1;
        //    while (inOut)
        //    {
        //        Console.Write("=>");
        //        int idMarca = int.Parse(Console.ReadLine());
        //        inOut = marcas.Exists(marca => marca.idMarca.Equals(idMarca));
        //        if (inOut == true)
        //        {
        //            index = marcas.FindIndex(marca => marca.idMarca.Equals(idMarca));
        //            inOut = false;
        //        }
        //        else { Console.WriteLine("Marca não encontada."); }
        //    }
        //    Console.Write("Data de Fabrico:");
        //    DateTime dataFabrico = DateTime.Parse(Console.ReadLine());

        //    // Obtém o último índice registrado na lista
        //    int id = Garantias.Count > 0 ? Garantias.Count + 1 : 1;
        //    //Garantia Garantia = new Garantia(id, nome, descr, marcas[index], dataFabrico);

        //    // Adiciona a marca à lista
        //    Garantias.Add(Garantia);

        //    Console.WriteLine("\nGarantia adicionado com sucesso. ID do Garantia: " + id);
        //    Console.WriteLine("\n");
        //}
        //public void ListarGarantia(List<Garantia> Garantias)
        //{
        //    Console.WriteLine("\nLista de Garantias:");
        //    int i = -1;
        //    foreach (Garantia Garantia in Garantias)
        //    {
        //        i++;
        //        Console.WriteLine($"\nId Garantia: {Garantia.idGarantia} " +
        //            $"\nNome: {Garantia.nameGarantia}" +
        //            $"\nDescrição: {Garantia.descricao}" +
        //            $"\nMarca:{Garantia.marca.nomeMarca}" +
        //            $"\nData de Fabrico:{Garantia.dataFabrico}");
        //    }
        //    Console.WriteLine("\n");
        //}
        //public void EditarGarantia(List<Garantia> Garantias, List<Marca> marcas)
        //{
        //    Console.WriteLine("\nEditar Marca:");
        //    Console.Write("Id da Marca a ser editada: ");
        //    int id = int.Parse(Console.ReadLine());
        //    int index = Garantias.FindIndex(Garantia => Garantia.idGarantia.Equals(id));

        //    if (index >= 0)
        //    {
        //        Console.Write("Novo Nome: ");
        //        Garantias[index].nameGarantia = Console.ReadLine();
        //        Console.Write("Descrição: ");
        //        Garantias[index].descricao = Console.ReadLine();
        //        Console.WriteLine("Selecione a Marca (id):");
        //        foreach (Marca marca in marcas)
        //        {
        //            Console.WriteLine($"{marca.idMarca} - {marca.nomeMarca} ");
        //        }
        //        bool inOut = true;
        //        int indexMarca = -1;
        //        while (inOut)
        //        {
        //            Console.Write("=>");
        //            int idMarca = int.Parse(Console.ReadLine());
        //            inOut = marcas.Exists(marca => marca.idMarca.Equals(idMarca));
        //            if (inOut == true) { Console.WriteLine("Marca não encontada."); }
        //            else { indexMarca = marcas.FindIndex(marca => marca.idMarca.Equals(idMarca)); }
        //        }
        //        Garantias[index].marca = marcas[indexMarca];
        //        Garantias[index].dataFabrico = DateTime.Parse(Console.ReadLine());
        //        Console.WriteLine("Marca editada com sucesso.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Índice inválido. Nenhuma Marca editada.");
        //    }
        //    Console.WriteLine("\n");
        //}
        //public void RemoverGarantia(List<Garantia> Garantias)
        //{
        //    Console.WriteLine("\nRemover Pessoa:");
        //    Console.Write("Id do Garantia a ser excluída: ");
        //    int id = int.Parse(Console.ReadLine());
        //    int index = Garantias.FindIndex(Garantia => Garantia.idGarantia.Equals(id));

        //    if (index >= 0)
        //    {
        //        Garantias.RemoveAt(index);
        //        Console.WriteLine("Garantia excluído com sucesso.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Índice inválido. Nenhuma Garantia excluído.");
        //    }
        //    Console.WriteLine("\n");
        //}


    }
}
