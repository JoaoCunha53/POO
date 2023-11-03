using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal class Artigo
    {
        /// <summary>
        /// Atributos Class Artigo
        /// </summary>
        public int idArtigo { get; set; }
        public Modelo modelo { get; set; }
        public Categoria categoria { get; set; }
        public Garantia garantia { get; set; }
        public double preco { get; set; }


        /// <summary>
        /// Construtores Class Artigo
        /// </summary>

        public Artigo() { }

        public Artigo(int idArtigo, Modelo modelo, Categoria categoria, Garantia garantia, double preco) 
        {
            this.idArtigo = idArtigo;
            this.modelo = modelo;
            this.categoria = categoria;
            this.garantia = garantia;
            this.preco = preco;
        }

        ///<summary>
        ///Metodos Class Artigo
        /// </summary>
    }
}
