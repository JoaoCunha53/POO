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
    internal class Gestor : Pessoa
    {
        /// <summary>
        /// Metodos Class Gestor
        /// </summary>
        public void Editar(Pessoa pessoa)
        {
            bool inOut = true;
            while (inOut)
            {
                Console.Clear();
                Console.WriteLine("\nEditar Perfil:");
                Console.WriteLine($"\n1 - Nome: {pessoa.nomeCompleto}" +
                       $"\n2 - Data Nascimento: {pessoa.dataNascimento}" +
                       $"\n3 - NºTelefone: {pessoa.nTelemovel}" +
                       $"\n4 - Nif: {pessoa.nif}" +
                       $"\n5 - Morada: {pessoa.morada}" +
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
                        pessoa.nomeCompleto = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("\nData de Nascemento: ");
                        pessoa.dataNascimento = DateOnly.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("\nNºTelefone: ");
                        pessoa.nTelemovel = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("\nMorada: ");
                        pessoa.nif = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("\nMorada: ");
                        pessoa.morada = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Valor selecionado é invalido.");
                        break;

                }
            }
            Console.WriteLine("\n");
        }
       
    }
}
