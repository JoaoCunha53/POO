using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstrataMaisInterface
{
    internal class Bicicleta : Veiculo , IVeiculoEletrico
    {
        public Bicicleta(string marca, string modelo) : base(marca, modelo) 
        {
        
        }
        public override void Mover()
        {
            Console.WriteLine($"A bicicleta {Marca} - {Modelo} está em movimento.");
        }

        public void CarregarBateria()
        {
            Console.WriteLine("Carregando a bateria da bicicleta elétrica.");
        }

    }
}
