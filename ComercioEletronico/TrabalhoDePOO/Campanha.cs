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
    internal class Campanha
    {
        /// <summary>
        /// Atributos Class Campanha
        /// </summary>
        public int idCampanha {  get; set; }
        public string nomeCamanha { get; set; }
        public double desconto { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get;}

        /// <summary>
        /// Construtor Class Campanha
        /// </summary>
        public Campanha() { }
        public Campanha(int idCampanha, string nomeCamanha, double desconto, DateTime dataInicio, DateTime dataFim)
        {
            this.idCampanha = idCampanha;
            this.nomeCamanha = nomeCamanha;
            this.desconto = desconto;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
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
        public int GuardarDados(string FilePath, List<Campanha> campanha)
        {
            try
            {
                // Serialização para CSV
                using (var writer = new StreamWriter(FilePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(campanha);
                }
                return 1;
            }
            catch { return 0; }
        }
        public void Adicionar(List<Campanha> campanhas)
        {
            Console.WriteLine("\nAdicionar Campanha:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Desconto: ");
            double desconto = double.Parse(Console.ReadLine());
            Console.Write("Data Inicio: ");
            DateTime dataInicio = DateTime.Parse(Console.ReadLine());
            Console.Write("Data Fim: ");
            DateTime dataFim = DateTime.Parse(Console.ReadLine());
            // Obtém o último índice registrado na lista
            int id = campanhas.Count > 0 ? campanhas.Count + 1 : 1;
            Campanha campanha = new Campanha(id, nome,desconto,dataInicio,dataFim);
            // Adiciona a marca à lista
            campanhas.Add(campanha);
            Console.WriteLine($"\nA campanha {nome} foi adicionada com sucesso. ID da campanha: " + id);
            Console.WriteLine("\n");
        }
        public void Listar(List<Campanha> campanhas)
        {
            Console.WriteLine("\nLista de Campanhas:");
            int i = -1;
            foreach (Campanha campanha in campanhas)
            {
                i++;
                Console.WriteLine($"Id Campanha:{campanha.idCampanha}" +
                    $"\nNome: {campanha.nomeCamanha}" +
                    $"\nDesconto:{campanha.dataInicio}" +
                    $"\nData do Inicio:{campanha.dataInicio}" +
                    $"\nData do Fim:{campanha.dataFim}");
            }
            Console.WriteLine("\n");
        }
        public void Editar(List<Campanha> campanhas)
        {
            Console.WriteLine("\nEditar Campanha:");
            Console.Write("Id da campanha a ser editada: ");
            int id = int.Parse(Console.ReadLine());
            int index = campanhas.FindIndex(campanha => campanha.idCampanha.Equals(id));
            Console.WriteLine($"\n1 - Nome: {campanhas[index].nomeCamanha}" +
                 $"\n2 - Desconto:{campanhas[index].dataInicio}" +
                 $"\n3 - Data do Inicio:{campanhas[index].dataInicio}" +
                 $"\n4 - Data do Fim:{campanhas[index].dataFim}" +
                 $"\n0 - Sair");

           
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
                        Console.Write("\nNome:");
                        campanhas[index].nomeCamanha = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("\nDesconto:");
                        campanhas[index].desconto = double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("\nDataInicio:");
                        campanhas[index].dataInicio = DateTime.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("\nData do Fim:");
                        campanhas[index].dataInicio = DateTime.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Valor selecionado é invalido.");  
                        break;
           
                }
            }
            Console.WriteLine("\n");
        }
        public void Remover(List<Campanha> campanhas)
        {
            Console.WriteLine("\nRemover Campanha:");
            Console.Write("Id da Campanha a ser excluída: ");
            int id = int.Parse(Console.ReadLine());
            int index = campanhas.FindIndex(campanha => campanha.idCampanha.Equals(id));

            if (index >= 0)
            {
                campanhas.RemoveAt(index);
                Console.WriteLine("Campanha excluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma Campanha excluída.");
            }
            Console.WriteLine("\n");
        }

    }
}
