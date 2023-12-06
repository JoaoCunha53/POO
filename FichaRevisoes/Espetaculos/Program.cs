namespace Espetaculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Espetaculo espetaculo = new Espetaculo();
            List<Espetaculo> listEspetaculo = new List<Espetaculo>();
            bool inOut = true;

            while (inOut) 
            {
                Console.WriteLine("1 - Registar Espetaculos");
                Console.WriteLine("2 - Consultar Espetaculos");
                Console.WriteLine("0 - Sair");
                int op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 0:
                        inOut = false; 
                        break;
                    case 1:
                        listEspetaculo.Add(espetaculo.RegistarEspetaculo());
                        break; 
                    case 2:
                        foreach(Espetaculo esp in listEspetaculo) 
                        {
                            espetaculo.ListarEspetaculo(esp);
                        }
                        break;
                }
            }

        }
    }
}