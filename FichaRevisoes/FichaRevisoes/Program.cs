using ContasBancarias;

namespace FichaRevisoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta callConta = new Conta();

            //List<Conta> listConta = new List<Conta>();
            List<ContaSalario> listContaSalarios = new List<ContaSalario>();
            List<Conta> listContasBancarias = new List<Conta>();
            List<Cliente> listaCliente = new List<Cliente>();

            List<Conta> listConta = (List<Conta>)callConta.SelectElements(typeof(Conta));


        }
    }
}