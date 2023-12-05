using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias
{
    internal class Cliente
    {
        //Atributos
        public string nome { get; set; }
        public string email { get; set;}
        public int  numeroCliente { get; set;}

        //Construtor
        public Cliente(string nome, string email, int numeroCliente) 
        {
            this.nome = nome;
            this.email = email;
            this.numeroCliente = numeroCliente;
        }

    }
}
