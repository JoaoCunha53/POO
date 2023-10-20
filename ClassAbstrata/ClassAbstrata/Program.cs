namespace ClassAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Toyota", "XPTO" , 1000);

            meuCarro.LigarMotor();
            meuCarro.Mover();

        }
    }
}