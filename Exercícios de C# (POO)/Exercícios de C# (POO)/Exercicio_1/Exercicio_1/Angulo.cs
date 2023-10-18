using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Angulo
    {

        private double Grau { get; set; }
        private double Radiano { get; set; }

        public Angulo()
        {
            Grau = 0;
            Radiano = 0;
        }

        //Metodos

        public double DevolverRadiano(double grau)
        {
            Radiano = (grau / 180 * double.Pi);
            return Radiano;
        }
        public double DevolverGrau(double radiano)
        {
            Grau = (radiano / double.Pi * 180);
            return Grau;
        }



    }
}
