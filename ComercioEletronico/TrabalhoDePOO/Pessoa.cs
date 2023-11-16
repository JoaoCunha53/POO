using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal class Cliente
    {
        ///<summary>
        ///Atributos Class Clientes
        ///</summary>
        public int idCliente {  get; set; }
        public string nomeCompleto { get; set; }
        public DateTime dataNascimento { get; set; }
        public decimal nif { get; set; }
        public decimal nTelemovel { get; set; }
        public string email { get; set;}
        public string morada { get; set;}
        ///<summary>
        ///Construtor Class Cliente 
        /// </summary>
        public Cliente() { }
        public Cliente(int idCliente, string nomeCompleto, DateTime dataNascimento, decimal nif,
            decimal nTelemovel, string email, string morada)
        {
            this.idCliente = idCliente;
            this.nomeCompleto = nomeCompleto;
            this.dataNascimento = dataNascimento;
            this.nif = nif;
            this.nTelemovel = nTelemovel;
            this.email = email;
            this.morada = morada;
        }



    }
}
