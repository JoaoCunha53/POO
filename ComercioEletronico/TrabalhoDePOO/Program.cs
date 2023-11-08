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

        static List<Garantia> garantias = new List<Garantia>();
        static Garantia garantia = new Garantia();
        

        static void Main(string[] args)
        {
            marcas = marca.CarregarDados("marcas.csv");
            modelos = modelo.CarregarDados("modelo.csv");
            garantias = garantia.CarregarDados("garantia.csv");

            bool inOut = true;
            while (inOut)
            {

                Console.WriteLine("--- Menu ---");
                Console.WriteLine("\n1 - Gerir Marcas");
                Console.WriteLine("2 - Gerir Modelos");
                Console.WriteLine("3 - Gerir Garantias");
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

                }


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
                    Console.WriteLine("Ocorreu um erro ao gravar os dados das garantias.");
                }

            }
        }
    }
}