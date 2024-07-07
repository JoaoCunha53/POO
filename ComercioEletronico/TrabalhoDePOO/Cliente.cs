using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoDePOO.@internal;
using System.Reflection;

namespace TrabalhoDePOO
{
    internal class Cliente : Pessoa , IJobsCliente
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
        public void ListarClientes(List<Pessoa> clientes)
        {
            foreach(Pessoa cliente in clientes)
            {
                if (cliente.funcao == 1)
                {
                    Console.WriteLine($"Id Cliente: {cliente.idPessoa}" +
                       $"\nNome: {cliente.nomeCompleto}" +
                       $"\nData Nascimento: {cliente.dataNascimento}" +
                       $"\nNºTelefone: {cliente.nTelemovel}" +
                       $"\nNif: {cliente.nif}" +
                       $"\nMorada: {cliente.morada}");
                }
            }
        }
        public void Editar(Pessoa pessoas)
        {
            bool inOut = true;
            while (inOut)
            {
                Console.Clear();
                Console.WriteLine("\nEditar Perfil:");
                Console.WriteLine($"\n1 - Nome: {pessoas.nomeCompleto}" +
                       $"\n2 - Data Nascimento: {pessoas.dataNascimento}" +
                       $"\n3 - NºTelefone: {pessoas.nTelemovel}" +
                       $"\n4 - Nif: {pessoas.nif}" +
                       $"\n5 - Morada: {pessoas.morada}" +
                       $"\n0 - Sair");

                Console.Write("\nSelecione o campo para editar: ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Write("\nNome: ");
                        pessoas.nomeCompleto = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("\nData de Nascemento: ");
                        pessoas.dataNascimento = DateOnly.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("\nNºTelefone: ");
                        pessoas.nTelemovel = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("\nMorada: ");
                        pessoas.nif = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("\nMorada: ");
                        pessoas.morada = Console.ReadLine();
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
