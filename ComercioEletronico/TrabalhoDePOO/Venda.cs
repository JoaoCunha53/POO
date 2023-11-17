using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal class Venda
    {

        /// <sumary>
        /// Atributos Class Venda
        /// </sumary>
        public int idVenda { get; set; }
        public Pessoa cliente { get; set; }
        public Artigo artigo { get; set; }

    }
}
