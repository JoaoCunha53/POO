using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoDePOO.@internal;

namespace TrabalhoDePOO
{
    internal class Categoria : IJobsCategoria
    {

        /// <summary>
        /// Atributos Class Categoria
        /// </summary>
        public int idCategoria { get; set; }
        public string descr { get; set; }

        /// <summary>
        /// Construtor Class Categoria
        /// </summary>
        public Categoria() { }

        public Categoria(int idCategoria, string desc)
        {
            this.idCategoria = idCategoria;
            this.descr = desc;
        }

        ///<summary>
        ///Metodos Class Categoria
        /// </summary>
        public List<Categoria> CarregarDados(string FilePath)
        {
            List<Categoria> categorias = new List<Categoria>();
            if (File.Exists(FilePath))
            {

                using (var reader = new StreamReader(FilePath))
                {
                    using (var csv = new CsvReader(reader,
                        new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        //var loadedRecords = csv.GetRecords<Person>().ToList();
                        categorias = csv.GetRecords<Categoria>().ToList();

                    }
                }
            }
            return categorias;

        }
        public int GuardarDados(string FilePath, List<Categoria> categorias)
        {
            try
            {
                // Serialização para CSV
                using (var writer = new StreamWriter(FilePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(categorias);
                }
                return 1;
            }
            catch { return 0; }
        }
        public void Adicionar(List<Categoria> categorias)
        {
            Console.WriteLine("\nAdicionar Categoria:");
            Console.Write("\nCategoria: ");
            string desc = Console.ReadLine();
            // Obtém o último índice registrado na lista
            int id = categorias.Count > 0 ? categorias.Count + 1 : 1;
            Categoria categoria = new Categoria(id,desc);
            // Adiciona a marca à lista
            categorias.Add(categoria);
            Console.WriteLine($"\nA categoria {desc} foi adicionada com sucesso. ID da campanha: " + id);
            Console.WriteLine("\n");
        }
        public void Listar(List<Categoria> categorias)
        {
            Console.WriteLine("\nLista de Categoria:");
            int i = -1;
            foreach (Categoria categoria in categorias)
            {
                i++;
                Console.WriteLine($"Id Categoria: {categoria.idCategoria}" +
                    $" Nome: {categoria.descr}");
            }
            Console.WriteLine("\n");
        }
        public void Editar(List<Categoria> categorias)
        {
            Console.WriteLine("\nEditar Campanha:");
            Console.Write("Id da campanha a ser editada: ");
            int id = int.Parse(Console.ReadLine());
            int index = categorias.FindIndex(categoria => categoria.idCategoria.Equals(id));
            Console.WriteLine($"\nCategoria: {categorias[index].descr}");
            Console.Write("\nNova Categoria: ");
            categorias[index].descr = Console.ReadLine();          
            
            Console.WriteLine("\n");
        }
        public void Remover(List<Categoria> categorias)
        {
            Console.WriteLine("\nRemover Categoria:");
            Console.Write("Id da Categoria a ser excluída: ");
            int id = int.Parse(Console.ReadLine());
            int index = categorias.FindIndex(categoria => categoria.idCategoria.Equals(id));

            if (index >= 0)
            {
                categorias.RemoveAt(index);
                Console.WriteLine("Categoria excluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Categoria excluída.");
            }
            Console.WriteLine("\n");
        }


    }
}
