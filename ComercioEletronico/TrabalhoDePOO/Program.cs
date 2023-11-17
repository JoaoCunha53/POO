using System.Formats.Asn1;
using System.Globalization;
using System;
using CsvHelper;

namespace TrabalhoDePOO
{
    internal class Program
    {
        static List<Marca> marcas = new List<Marca>();
        static Marca marca = new Marca();
        static List<Modelo> modelos = new List<Modelo>();
        static Modelo modelo = new Modelo();
        static List<Campanha> campanhas = new List<Campanha>();
        static Campanha campanha = new Campanha();
        static List<Categoria> categorias = new List<Categoria>();
        static Categoria categoria = new Categoria();
        static List<Artigo> artigos = new List<Artigo>();
        static Artigo artigo = new Artigo();
        static List<Garantia> garantias = new List<Garantia>();
        static Garantia garantia = new Garantia();
        static List<Pessoa> pessoas = new List<Pessoa>();
        static Pessoa pessoa = new Pessoa();
        

        static void Main(string[] args)
        {
            marcas = marca.CarregarDados("marcas.csv");
            modelos = modelo.CarregarDados("modelo.csv");
            garantias = garantia.CarregarDados("garantia.csv");
            campanhas = campanha.CarregarDados("campanhas.csv");
            categorias = categoria.CarregarDados("categorias.csv");
            artigos = artigo.CarregarDados("artigos.csv");


            bool inOut = true;
            Console.WriteLine("Comercio Online");
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Resgisto");
            Console.WriteLine("0 - Sair");
            int opcaoInico = int.Parse(Console.ReadLine());
            while (inOut)
            {
                switch (opcaoInico)
                {
                    case 0:
                        inOut = false;
                        Console.WriteLine("Volte Sempre");
                        break;
                    case 1:
                        inOut = false;
                        Login();
                        break;
                    case 2:
                        inOut = false;
                        
                        break;
                    default:
                        Console.WriteLine("Selecionar o valor correto.");
                        break;
                }
            }            

            if (marca.GuardarDados("marcas.csv", marcas) < 1)
            {
                Console.WriteLine("Ocorreu um erro ao gravar os dados das marcas.");
            }
            if (modelo.GuardarDados("modelo.csv", modelos) < 1)
            {
                Console.WriteLine("Ocorreu um erro ao gravar os dados dos modelos.");
            }
            if (garantia.GuardarDados("garantia.csv", garantias) < 1)
            {
                Console.WriteLine("Ocorreu um erro ao gravar os dados dos campanhas.");
            }
            if (campanha.GuardarDados("campanhas.csv", campanhas) < 1)
            {
                Console.WriteLine("Ocorreu um erro ao gravar os dados dos campanhas.");
            }
            if (categoria.GuardarDados("categorias.csv", categorias) < 1)
            {
                Console.WriteLine("Ocorreu um erro ao gravar os dados dos categorias.");
            }
            if (artigo.GuardarDados("artigos.csv", artigos) < 1)
            {
                Console.WriteLine("Ocorreu um erro ao gravar os dados dos artigo.");
            }
            Console.ReadKey();
        }

        public static void MenuMarcas()
        {
            Console.Clear();
            bool inOut = true;
            while (inOut)
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("\n1 - Listar Marcas");
                Console.WriteLine("2 - Adicionar Marca");
                Console.WriteLine("3 - Editar Marca");
                Console.WriteLine("4 - Remover Marca");
                Console.WriteLine("0 - Sair");
                Console.Write("\n=> ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Clear();
                        marca.ListarMarca(marcas);
                        break;
                    case 2:
                        Console.Clear();
                        marca.AdicionarMarca(marcas);
                        break;
                    case 3:
                        Console.Clear();
                        marca.EditarMarca(marcas);
                        break;
                    case 4:
                        Console.Clear();
                        marca.RemoverMarca(marcas);
                        break;

                }


            }
        }
        public static void MenuModelos()
        {
            bool inOut = true;
            Console.Clear();
            while (inOut)
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("\n1 - Listar Modelos");
                Console.WriteLine("2 - Adicionar Modelo");
                Console.WriteLine("3 - Editar Modelo");
                Console.WriteLine("4 - Remover Modelo");
                Console.WriteLine("0 - Sair");
                Console.Write("\n=> ");

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Clear();
                        modelo.ListarModelo(modelos);
                        break;
                    case 2:
                        Console.Clear();
                        modelo.AdicionarModelo(modelos, marcas);
                        break;
                    case 3:
                        Console.Clear();
                        modelo.EditarModelo(modelos, marcas);
                        break;
                    case 4:
                        Console.Clear();
                        modelo.RemoverModelo(modelos);
                        break;

                }
            }
        }
        public static void MenuCampanha()
        {
            bool inOut = true;
            Console.Clear();
            while (inOut)
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("\n1 - Listar Campanhas");
                Console.WriteLine("2 - Adicionar Campanhas");
                Console.WriteLine("3 - Editar Campanhas");
                Console.WriteLine("4 - Remover Campanhas");
                Console.WriteLine("0 - Sair");
                Console.Write("\n=> ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Clear();
                        campanha.Listar(campanhas);
                        break;
                    case 2:
                        Console.Clear();
                        campanha.Adicionar(campanhas);
                        break;
                    case 3:
                        Console.Clear();
                        campanha.Editar(campanhas);
                        break;
                    case 4:
                        Console.Clear();
                        campanha.Remover(campanhas);
                        break;
                }
            }
        }
        public static void MenuGarantias()
        {
            Console.Clear();
            bool inOut = true;
            while (inOut)
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("\n1 - Listar Garantias");
                Console.WriteLine("2 - Adicionar Garantia");
                Console.WriteLine("3 - Editar Garantia");
                Console.WriteLine("4 - Remover Garantia");
                Console.WriteLine("0 - Sair");
                Console.Write("\n=> ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Clear();
                        garantia.ListarGarantia(garantias);
                        break;
                    case 2:
                        Console.Clear();
                        garantia.AdicionarGarantia(garantias);
                        break;
                    case 3:
                        Console.Clear();
                        garantia.EditarGarantia(garantias);
                        break;
                    case 4:
                        Console.Clear();
                        garantia.RemoverGarantia(garantias);
                        break;

                }

            }
        }
        public static void MenuCategoria()
        {
            bool inOut = true;
            Console.Clear();
            while (inOut)
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("\n1 - Listar Categoria");
                Console.WriteLine("2 - Adicionar Categoria");
                Console.WriteLine("3 - Editar Categoria");
                Console.WriteLine("4 - Remover Categoria");
                Console.WriteLine("0 - Sair");
                Console.Write("\n=> ");

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Clear();
                        categoria.Listar(categorias);
                        break;
                    case 2:
                        Console.Clear();
                        categoria.Adicionar(categorias);
                        break;
                    case 3:
                        Console.Clear();
                        categoria.Editar(categorias);
                        break;
                    case 4:
                        Console.Clear();
                        categoria.Remover(categorias);
                        break;

                }
                if (garantia.GuardarDados("garantia.csv", garantias) < 1)
                {
                    Console.WriteLine("Ocorreu um erro ao gravar os dados das garantias.");
                }

            }
        }
        public static void MenuArtigo()
        {
            bool inOut = true;
            Console.Clear();
            while (inOut)
            {
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("\n1 - Listar Artigos");
                Console.WriteLine("2 - Adicionar Artigos");
                Console.WriteLine("3 - Editar Artigos");
                Console.WriteLine("4 - Remover Artigos");
                Console.WriteLine("0 - Sair");
                Console.Write("\n=> ");

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Clear();
                        artigo.Listar(artigos);
                        break;
                    case 2:
                        Console.Clear();
                        artigo.Adicionar(artigos,modelos,categorias,garantias);
                        break;
                    case 3:
                        Console.Clear();
                        artigo.Editar(artigos, modelos, categorias, garantias);
                        break;
                    case 4:
                        Console.Clear();
                        artigo.Remover(artigos);
                        break;

                }

            }
        }
        public static void MenuGestor() 
        {
            bool inOut = true;
            while (inOut)
            {
                Console.Clear();
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("\n1 - Gerir Marcas");
                Console.WriteLine("2 - Gerir Modelos");
                Console.WriteLine("3 - Gerir Garantias");
                Console.WriteLine("4 - Gerir Campanhas");
                Console.WriteLine("5 - Gerir Categorias");
                Console.WriteLine("6 - Gerir Artigos");
                Console.WriteLine("0 - Sair");
                Console.Write("\n=> ");

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Clear();
                        MenuMarcas();
                        break;
                    case 2:
                        Console.Clear();
                        MenuModelos();
                        break;
                    case 3:
                        Console.Clear();
                        MenuGarantias();
                        break;
                    case 4:
                        Console.Clear();
                        MenuCampanha();
                        break;
                    case 5:
                        Console.Clear();
                        MenuCategoria();
                        break;
                    case 6:
                        Console.Clear();
                        MenuArtigo();
                        break;

                }


            }
        }
        public static void MenuCilente()
        {
            bool inOut = true;
            while (inOut)
            {
                Console.Clear();
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1 - Listar Artigos");
                Console.WriteLine("2 - Encomendas");

                Console.WriteLine("0 - Sair");
                Console.Write("\n=> ");

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Clear();
                        artigo.Listar(artigos);
                        break;
                    case 2:
                        Console.Clear();
                        
                        break;
                    

                }


            }
        }

        public static void Login()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Palavra-Pass: ");
            string pass = Console.ReadLine();
            int index = pessoas.FindIndex(pessoa => pessoa.email.Equals(email) && pessoa.chave.Equals(pass));
           if ( index != null ) 
            {
                switch(pessoas[index].funcao)
                {
                    case 1:
                        MenuCliente(),
                        break;
                    case 2:
                        MenuGestor();
                        break;
                }
            }
           else
            {
                Console.WriteLine("");
            }

        }

    }
}