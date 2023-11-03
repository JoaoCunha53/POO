using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal class Categoria
    {

        /// <summary>
        /// Atributos Class Categoria
        /// </summary>
        public int idCategoria { get; set; }
        public string nome { get; set; }
        public string descr { get; set; }

        /// <summary>
        /// Construtor Class Categoria
        /// </summary>
        public Categoria() { }

        public Categoria(int idCategoria, string nome , string desc)
        {
            this.idCategoria = idCategoria;
            this.nome = nome;
            this.descr = desc;
        }

        ///<summary>
        ///Metodos Class Categoria
        /// </summary>



    }
}
