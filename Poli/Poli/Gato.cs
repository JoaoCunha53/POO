using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poli
{
    internal class Gato : Animal
    {
        public int NumPatas { get; set; }

        public Gato()
        {
            NumPatas = 0;
        }
        public Gato(int numPatas) 
        {
            NumPatas = numPatas;
        }
        public void MostrarNumPatas()
        {
            Console.WriteLine("O numero de patas gato é {0}",NumPatas);
        }
        public override void FazerSom()
        {
            Console.WriteLine("Som do gato...");
        }
    }
}
