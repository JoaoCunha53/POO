namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Tabuleiro tabuleiro = new Tabuleiro();

            Console.WriteLine("•    Defina um método que coloque uma Torre na posição i,j.");
            tabuleiro.ColocarPeças(9, 10,"Torre");
            Console.WriteLine("\n");
            Console.WriteLine("•    Defina um método para verificar se determinada posição está ocupada ou não.\n    Caso esteja ocupada, indique que peça lá está posicionada.");
            tabuleiro.VerificarPossicao(1, 1);
            Console.WriteLine("\n");
            Console.WriteLine("•    Defina um método que indique em que posições estão posicionados os Bispos");
            tabuleiro.ProcurarPocicaoDasPeças("Bispo");

            Console.ReadKey();

        }
    }
}