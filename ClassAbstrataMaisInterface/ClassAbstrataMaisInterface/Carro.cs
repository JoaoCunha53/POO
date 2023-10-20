using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstrataMaisInterface
{
    internal class Carro : Veiculo
    {
        public int Kms { get; set; }
        public Carro(string marca, string modelo, int kms) : base(marca, modelo)
        {
            Kms = kms;
        }

        //Implementação do método abstrato
        public override void Mover()
        {
            Console.WriteLine($"O carro {Marca} {Modelo} está a mover-se. KMS -> {Kms}");
        }

        public void CarregarBateria()
        {
            Console.WriteLine("Carregar a bateria do carro eletrico.");
        }

    }

}
