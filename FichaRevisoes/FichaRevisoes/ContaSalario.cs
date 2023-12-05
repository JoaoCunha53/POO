using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias
{
    internal class ContaSalario : Conta
    {
        //Atributo 
        public string empresa { get; set; }

        //Construtor
        public ContaSalario(string titular, double saldo, string empresa) : base (titular, saldo)
        {
            this.empresa = titular;
        }



    }
}
