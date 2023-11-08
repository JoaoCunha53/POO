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
    internal class Pessoa
    {
        ///<summary>
        ///Atributos Class Clientes
        ///</summary>
        public int idPessoa { get; set; }
        public string nomeCompleto { get; set; }
        public DateTime dataNascimento { get; set; }
        public decimal nif { get; set; }
        public decimal nTelemovel { get; set; }
        public string email { get; set; }
        public string morada { get; set; }

        ///<summary>
        ///Construtor Class Cliente 
        /// </summary>
        /// 


        public Pessoa() { }
        public Pessoa(int idPessoa, string nomeCompleto, DateTime dataNascimento, decimal nif,
            decimal nTelemovel, string email, string morada)
        {
            this.idPessoa = idPessoa;
            this.nomeCompleto = nomeCompleto;
            this.dataNascimento = dataNascimento;
            this.nif = nif;
            this.nTelemovel = nTelemovel;
            this.email = email;
            this.morada = morada;
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
        public void AdicionarGarantia(List<Garantia> garantia)
        {
            Console.WriteLine("\nValidade Garantia:");
            int validade = int.Parse(Console.ReadLine());

            Console.Write("Tipo Garantia: ");
            Console.Write("\n1 - Garantia Legal ");
            Console.Write("\n2 - Garantia Contratual ");
            Console.Write("\n3 - Garantia Estendida ");

            int tipo = 0;
            string tipoGarantia = "";
            bool inOut = true;
            while (inOut)
            {
                Console.Write("\n=> ");
                tipo = int.Parse(Console.ReadLine());

                switch (tipo)
                {
                    case 1:
                        inOut = false;
                        tipoGarantia = "Garantia Legal";
                        break;
                    case 2:
                        inOut = false;
                        tipoGarantia = "Garantia Contratual";
                        break;
                    case 3:
                        inOut = false;
                        tipoGarantia = "Garantia Estendida";
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }
            }


            int id = garantia.Count > 0 ? garantia[garantia.Count - 1].idGarantia + 1 : 1;
            Garantia novaGarantia = new Garantia(id, tipoGarantia, validade);

            garantia.Add(novaGarantia);

            Console.WriteLine("\nGarantia adicionada com sucesso. ID da garantia: " + id);
            Console.WriteLine("\n");
        }

        public void ListarGarantia(List<Garantia> Garantias)
        {
            Console.WriteLine("\nLista de Garantias:");
            int i = -1;
            foreach (Garantia Garantia in Garantias)
            {
                i++;
                Console.WriteLine($"\nId Garantia: {Garantia.idGarantia} " +
                    $"\nNome: {Garantia.tipoGarantia}" +
                    $"\nValidade: {Garantia.validade}" + " anos.");
            }
            Console.WriteLine("\n");
        }
        public void EditarGarantia(List<Garantia> Garantias)
        {
            Console.WriteLine("\nEditar Garantia:");
            Console.Write("Id da Garantia a ser editada: ");
            int id = int.Parse(Console.ReadLine());
            int index = Garantias.FindIndex(Garantia => Garantia.idGarantia.Equals(id));

            Console.WriteLine($"\nNome: {Garantias[index].tipoGarantia}" +
                   $"\nValidade: {Garantias[index].validade}" + " anos.");

            if (index >= 0)
            {

                // Garantias[index].tipoGarantia = Console.ReadLine();

                Console.Write("Tipo Existentes de Garantia: ");
                Console.Write("\n1 - Garantia Legal ");
                Console.Write("\n2 - Garantia Contratual ");
                Console.Write("\n3 - Garantia Estendida ");
                Console.WriteLine();
                Console.WriteLine();

                int tipo = 0;
                string tipoGarantia = "";
                bool inOut = true;
                while (inOut)
                {
                    Console.WriteLine();
                    Console.Write("\nNovo tipo de garantia: ");
                    Console.Write("\n => ");
                    tipo = int.Parse(Console.ReadLine());

                    switch (tipo)
                    {
                        case 1:
                            inOut = false;
                            Garantias[index].tipoGarantia = "Garantia Legal";
                            break;
                        case 2:
                            inOut = false;
                            Garantias[index].tipoGarantia = "Garantia Contratual";
                            break;
                        case 3:
                            inOut = false;
                            Garantias[index].tipoGarantia = "Garantia Estendida";
                            break;
                        default:
                            Console.WriteLine("Valor inválido");
                            break;
                    }
                }


                Console.Write("Nova Validade: ");
                Garantias[index].validade = int.Parse(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Marca editada.");
            }
            Console.WriteLine("\n");
        }
        public void RemoverGarantia(List<Garantia> Garantias)
        {
            Console.WriteLine("\nRemover Garantia:");
            Console.Write("Id da Garantia a ser excluída: ");
            int id = int.Parse(Console.ReadLine());
            int index = Garantias.FindIndex(Garantia => Garantia.idGarantia.Equals(id));

            if (index >= 0)
            {
                Garantias.RemoveAt(index);
                Console.WriteLine("Garantia excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Garantia excluído.");
            }
            Console.WriteLine("\n");
        }






    }

    }
