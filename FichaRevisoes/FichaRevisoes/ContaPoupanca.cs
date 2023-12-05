using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias
{
    internal class ContaPoupanca : Conta
    {

        //Atributos
        public double TaxaJuros { get; set; }
        //Construtor
        public ContaPoupanca(string titular, double saldo,double taxaDeJuros)  : base (titular, saldo) 
        {
            this.titular = titular;
        }
        //Metodo
        

    }
}
