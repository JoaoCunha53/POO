namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1.1
            Console.WriteLine("\nExercicio 1.1");
            Lampada lampadaAux = new Lampada();
            lampadaAux.Acender();
            Console.WriteLine("A lampada esta ligada: {0}", lampadaAux.Estado());

            lampadaAux.Apagar();
            Console.WriteLine("A lampada esta ligada: {0}", lampadaAux.Estado());

            //Exercicio 1.2
            Console.WriteLine("\nExercicio 1.2");
            Triangulo trianguloAux = new Triangulo();
            trianguloAux.Dimensoes(15,16,17);
            Console.WriteLine("\n O triangulo é" + trianguloAux.Tipo());

            //Exercicio 2 - 2.3
            Console.WriteLine("\nExercicio 2 - 2.3");
            Pessoa pessoa = new Pessoa();
            pessoa.verInfo();

            Pessoa pessoaDois = new Pessoa("Joao");
            pessoaDois.verInfo();
            Pessoa pessoaTrez = new Pessoa(11);
            pessoaTrez.verInfo();
            Pessoa pessoaQuatro = new Pessoa("Joao",11);
            pessoaQuatro.verInfo();


            //Exercicio 2 - 2.3
            Console.WriteLine("\nExercicio 2.4");
            Angulo angulo = new Angulo();
            Console.WriteLine("O valor do radiano {0}", angulo.DevolverRadiano(double.Cos(180)));
            Console.WriteLine("O valor Do grau {0}", angulo.DevolverGrau(double.Pi/2));


            Console.ReadKey();
        }
    }
}