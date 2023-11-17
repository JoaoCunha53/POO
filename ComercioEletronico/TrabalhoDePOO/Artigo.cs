using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal class Artigo 
    {
        /// <summary>
        /// Atributos Class Artigo
        /// </summary>
        public int idArtigo { get; set; }
        public Modelo modelo { get; set; }
        public int stock { get; set; }
        public Categoria categoria { get; set; }
        public Garantia garantia { get; set; }
        public double precoUni { get; set; }
        /// <summary>
        /// Construtores Class Artigo
        /// </summary>
        public Artigo() { }
        public Artigo(int idArtigo, Modelo modelo,int stock ,Categoria categoria, Garantia garantia, double precoUni) 
        {
            this.idArtigo = idArtigo;
            this.modelo = modelo;
            this.stock = stock;
            this.categoria = categoria;
            this.garantia = garantia;
            this.precoUni = precoUni;
        }

        ///<summary>
        ///Metodos Class Artigo XPTO
        /// </summary>

        public List<Artigo> CarregarDados(string FilePath)
        {
            List<Artigo> artigos = new List<Artigo>();
            if (File.Exists(FilePath))
            {

                using (var reader = new StreamReader(FilePath))
                {
                    using (var csv = new CsvReader(reader,
                        new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        //var loadedRecords = csv.GetRecords<Person>().ToList();
                        artigos = csv.GetRecords<Artigo>().ToList();

                    }
                }
            }
            return artigos;

        }
        public int GuardarDados(string FilePath, List<Artigo> artigos)
        {
            try
            {
                // Serialização para CSV
                using (var writer = new StreamWriter(FilePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(artigos);
                }
                return 1;
            }
            catch { return 0; }
        }
        public void Adicionar(List<Artigo> artigos,List<Modelo> modelos,List<Categoria> categorias,List<Garantia> garantias)
        {
            int i = 0;
            Console.WriteLine("\nAdicionar Artigo");
            Console.Write("Id do registo modelo: ");
            int idModelo = int.Parse(Console.ReadLine());
            Console.Write("Stock atual: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Id da Categoria: ");
            int idCategoria = int.Parse(Console.ReadLine());
            Console.Write("Id da Garantia: ");
            int idGarantia = int.Parse(Console.ReadLine());
            Console.Write("Id da Preço: ");
            double preçoPorUni = double.Parse(Console.ReadLine());

            // Obtém o último índice registrado na lista
            int id = artigos.Count > 0 ? artigos.Count + 1 : 1;

            Artigo artigo = new Artigo(id,
                modelos.Find(modelo => modelo.idModelo.Equals(idModelo)),
                stock,
                categorias.Find(categoria => categoria.idCategoria.Equals(idCategoria)),
                garantias.Find(garantia => garantia.idGarantia.Equals(idGarantia)),
                preçoPorUni);

            artigos.Add(artigo);
           
        }
        public void Listar(List<Artigo> artigos)
        {
            Console.WriteLine("\nLista de Artigo:");
            int i = -1;
            foreach (Artigo artigo in artigos)
            {
                i++;
                Console.WriteLine($"Id Artigo:{artigo.idArtigo}" +
                    $"\nModelo: {artigo.modelo.nameModelo}" +
                    $"\nMarca: {artigo.modelo.marca.nomeMarca}" +
                    $"\nDescrição:{artigo.modelo.descricao}" +
                    $"\nCategoria:{artigo.categoria.descr}" +
                    $"\nGarantia:{artigo.garantia.tipoGarantia} Validade: {artigo.garantia.validade}" +
                    $"\nStock:{artigo.stock}" +
                    $"\nPreço Unidade:{artigo.precoUni}");

            }
            Console.WriteLine("\n");
        }
        public void Editar(List<Artigo> artigos, List<Modelo> modelos, List<Categoria> categorias, List<Garantia> garantias)
        {
            Console.WriteLine("\nEditar Artigo:");
            Console.Write("Id da Artigo a ser editada: ");
            int id = int.Parse(Console.ReadLine());
            int index = artigos.FindIndex(artigo => artigo.idArtigo.Equals(id));
            Console.WriteLine($"\n1 - Id Modelo" +
                   $"\nModelo: {artigos[index].modelo.nameModelo}" +
                   $"\n     Marca: {artigos[index].modelo.marca.nomeMarca}" +
                   $"\n     Descrição:{artigos[index].modelo.descricao}" +
                   $"\n2 - Categoria:{artigos[index].categoria.descr}" +
                   $"\n3 - Garantia:{artigos[index].garantia.tipoGarantia}" +
                   $"\n4 - Stock:{artigos[index].stock}" +
                   $"\n5 - Preço Unidade:{artigos[index].precoUni}");


            bool inOut = true;
            while (inOut)
            {
                Console.Write("\nSelecione o campo para editar: ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Write("\nId Modelos:");
                        artigos[index].modelo = modelos.Find(modelo => modelo.idModelo.Equals(int.Parse(Console.ReadLine())));
                        break;
                    case 2:
                        Console.Write("\nId Categoria:");
                        artigos[index].categoria = categorias.Find(categoria => categoria.idCategoria.Equals(int.Parse(Console.ReadLine())));
                        break;
                    case 3:
                        Console.Write("\nId Categoria:");
                        artigos[index].garantia = garantias.Find(garantia => garantia.idGarantia.Equals(int.Parse(Console.ReadLine())));
                        break;
                    case 4:
                        Console.Write("\nStok:");
                        artigos[index].stock = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("\nPreço Unidade:");
                        artigos[index].precoUni = double.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Valor selecionado é invalido.");
                        break;

                }
            }
            Console.WriteLine("\n");
        }
        public void Remover(List<Artigo> artigos)
        {
            Console.WriteLine("\nRemover Artigo:");
            Console.Write("Id da Artigo a ser excluída: ");
            int id = int.Parse(Console.ReadLine());
            int index = artigos.FindIndex(artigo => artigo.idArtigo.Equals(id));

            if (index >= 0)
            {
                artigos.RemoveAt(index);
                Console.WriteLine("Artigo excluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Artigo excluída.");
            }
            Console.WriteLine("\n");
        }


    }
}
