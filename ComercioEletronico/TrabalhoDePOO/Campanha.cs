using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal class Campanha
    {
        /// <summary>
        /// Atributos Class Campanha
        /// </summary>
        public int idCampanha {  get; set; }
        public string nomeCamanha { get; set; }
        public double desconto { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get;}

        /// <summary>
        /// Construtor Class Campanha
        /// </summary>
        public Campanha() { }
        public Campanha(int idCampanha, string nomeCamanha, double desconto, DateTime dataInicio, DateTime dataFim)
        {
            this.idCampanha = idCampanha;
            this.nomeCamanha = nomeCamanha;
            this.desconto = desconto;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
        }   
    }
}
