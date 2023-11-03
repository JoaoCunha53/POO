using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal class Stock
    {

        /// <summary>
        /// Atributos Class Stock
        /// </summary>
        public int idStock { get; set; }
        public int idArtigo { get; set; }
        public string quantidade { get; set; }
        /// <summary>
        /// Construtor Class Stock
        /// </summary>
        public Stock() { }
        public Stock(int idStock, int idArtigo , string quantidade)
        {
            this.idStock = idStock;
            this.idArtigo = idArtigo;
            this.quantidade = quantidade;
        }


    }
}
