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
    internal class Cliente : Pessoa
    {

        /// <summary>
        /// Metodos Class Garantia
        /// </summary>
        public List<Pessoa> CarregarDados(string FilePath)
        {
            List<Pessoa> clientes = new List<Pessoa>();
            if (File.Exists(FilePath))
            {

                using (var reader = new StreamReader(FilePath))
                {
                    using (var csv = new CsvReader(reader,
                        new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        //var loadedRecords = csv.GetRecords<Person>().ToList();
                        clientes = csv.GetRecords<Pessoa>().ToList();

                    }
                }
            }
            return clientes;

        }
        public int GuardarDados(string FilePath, List<Pessoa> clientes)
        {
            try
            {
                // Serialização para CSV
                using (var writer = new StreamWriter(FilePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(clientes);
                }
                return 1;
            }
            catch { return 0; }
        }
        public void Adicionar(List<Pessoa> clientes,string email, string chave)
        {
            int id = clientes.Count > 0 ? clientes[clientes.Count - 1].idPessoa + 1 : 1;
            Pessoa novoCliente = new Pessoa(id,null,DateOnly.Parse("01/01/0001"),0,0,null,email,chave,1);
            clientes.Add(novoCliente);

            Console.WriteLine("\nConta Criada com sucesso.");
            Console.WriteLine("\n");
        }
        public void Editar(List<Pessoa> pessoas, int id)
        {
            Console.WriteLine("\nEditar Perfil:");
            int index = pessoas.FindIndex(pessoa => pessoa.idPessoa.Equals(id));
            Console.WriteLine($"\n1 - Nome: {pessoas[index].nomeCompleto}" +
                   $"\n2 - Data Nascimento: {pessoas[index].dataNascimento}" +
                   $"\n3 - NºTelefone: {pessoas[index].nTelemovel}" +
                   $"\n4 - Nif:{pessoas[index].nif}" +
                   $"\n5 - Morada:{pessoas[index].morada} +" +
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
                        Console.Write("\nNome: ");
                        pessoas[index].nomeCompleto = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("\nData de Nascemento: ");
                        pessoas[index].dataNascimento = DateOnly.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("\nId Categoria: ");
                        pessoas[index].nTelemovel = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("\nMorada: ");
                        pessoas[index].nif = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("\nMorada: ");
                        pessoas[index].morada = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Valor selecionado é invalido.");
                        break;

                }
            }
            Console.WriteLine("\n");
        }

        public void Remover(List<Pessoa> clientes)
        {
            Console.WriteLine("\nEliminar conta Cliente :");
            Console.Write("Id do Cliente a ser excluída: ");
            int id = int.Parse(Console.ReadLine());
            int index = clientes.FindIndex(pessoa => pessoa.idPessoa.Equals(id));

            if (index >= 0)
            {
                clientes.RemoveAt(index);
                Console.WriteLine("Cliente excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhum Cliente excluído.");
            }
            Console.WriteLine("\n");
        }

    }
}
