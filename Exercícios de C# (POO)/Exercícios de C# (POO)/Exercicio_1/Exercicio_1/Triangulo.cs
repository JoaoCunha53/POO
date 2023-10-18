using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Triangulo
    {
        private double ladoA {  get; set; }
        private double ladoB { get; set;}
        private double ladoC { get; set;}

        public Triangulo()
        {
            ladoA = 0;
            ladoB = 0;
            ladoC = 0;
        }

        public void Dimensoes(double a, double b, double c)
        {
            ladoA = a; ladoB = b;   ladoC = c;
            Console.WriteLine("As dimensois do triangolo são: \n ladoA - {0} \n ladoB - {1} \n ladoC - {2} ", ladoA, ladoB, ladoC);
        }

        public string Tipo()
        {
            if (ladoA == ladoB && ladoA == ladoC) { return "Equilatero"; }
            if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC) { return "Escaleno"; }
            if (ladoA == ladoB && ladoA != ladoC || ladoC == ladoB && ladoC != ladoA ) { return "Isosceles"; }
            return "";
        }


    }
}
