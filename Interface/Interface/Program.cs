namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAutenticacao autenticacao = new AutenticacaoServico();

            bool autenticado = autenticacao.LogIn("123", "123");

            if(autenticado) 
            {
                Console.WriteLine("Utlizador autenticado com sucesso");
            }
            else
            {
                Console.WriteLine("Falha na autenticação");
            }


        }
    }
}