using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Lampada
    {
        //Propriedades
        private bool lampada {  get; set; }

        //Construtor
        public Lampada() { lampada = false; }

        //Metodo
        public void Acender()
        {
            lampada = true;
        }
        public void Apagar()
        {
            lampada = false;
        }
        public string Estado()
        {
            return Convert.ToString(lampada);
        }

    }
}
