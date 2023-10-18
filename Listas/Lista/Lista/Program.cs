using System.Linq;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numeros

            //List<int> numeros = new List<int> { 1,2,423,455,6,34,312,564};

            //while (true)
            //{
            //    Console.WriteLine("Introduza um número (ou '0' para sair): ");
            //    int numero = int.Parse(Console.ReadLine());

            //    if( numero == 0)
            //        break;
            //    numeros.Add(numero);
            //}

            //List<int> numeros = new List<int>();

            //Console.WriteLine("Quantos Numeros Deseja adicionar à lista? ");
            //int n = int.Parse(Console.ReadLine());

            //for(int i = 0;i<n;i++) 
            //{
            //    Console.Write("Indrozuda o numero {0} : ", i + 1);
            //    int numero = int.Parse(Console.ReadLine());
            //    numeros.Add(numero);
            //}

            //Console.WriteLine("Maior número na lista: {0}", numeros.Max());
            //Console.WriteLine("Menor número na lista: {0}", numeros.Min());


            //Console.WriteLine("\nNúmero na lista:");

            //foreach (int numero in numeros)
            //{
            //    Console.Write(numero + " ");
            //}

            //numeros.Sort();

            //Console.WriteLine("\nLista Ordenada:");

            //foreach (int numero in numeros)
            //{
            //    Console.Write(numero + " ");
            //}

            //numeros.Reverse();

            //Console.WriteLine("\nLista Invertida:");

            //foreach (int numero in numeros)
            //{
            //    Console.Write(numero + " ");
            //}


            //Nomes
            //List<string> nomes = new List<string> {"João", "João", "Maria", "Filipe", "Rita", "Ana" };

            //Console.WriteLine("Nomes da lista:");

            //foreach (var nome in nomes) { Console.WriteLine(nome); }

            //Console.Write("Introdus o nome desejado remover da lista: ");
            //string nomeRemover = Console.ReadLine();

            //if(nomes.Contains(nomeRemover))
            //{
            //    nomes.Remove(nomeRemover);
            //    Console.WriteLine("Nome {0} foi removido com sucesso.",nomeRemover);
            //}
            //else
            //{
            //    Console.WriteLine("Nome {0} não existe ná lista.");
            //}

            //Console.WriteLine("Nomes da lista após remover o nome: ");
            //foreach (var nome in nomes) { Console.WriteLine(nome); }


            Curso cursoCSharp = new Curso("Programação em C# (POO)");

            Aluno aluno1 = new Aluno("Nuno", 1001);
            Aluno aluno2 = new Aluno("Maria", 1001);
            Aluno aluno3 = new Aluno("Ana", 1001);

            cursoCSharp.AdicionarAluno(aluno1);
            cursoCSharp.AdicionarAluno(aluno2);
            cursoCSharp.AdicionarAluno(aluno3);

            cursoCSharp.ListarAlunos();

            Console.ReadKey();
        }
    }
}