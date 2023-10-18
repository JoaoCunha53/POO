namespace Poli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chamar os metodos:
            Animal animalOrigina = new Animal();
            Animal animal = new Cao();
            Animal animal2 = new Gato(4);

            animalOrigina.FazerSom();
            animal.FazerSom();
            animal2.FazerSom();

            Gato g = new Gato(4);
            Console.WriteLine(g.NumPatas);
        }
    }
}