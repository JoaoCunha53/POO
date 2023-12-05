using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias
{
    internal class Conta : IOperacoes
    {
        //Atributos 
        public string titular { get; set; }
        public double saldo { get; set; }

        //Construtor 
        public Conta() { }
        public Conta(string titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        //Metodos

        public bool InsertElement(object x)
        {
            return true;
        }
        public bool RemoveElement(object x)
        {
            return true;
        }
        public bool UpdateElement(object x)
        {
            return true;
        }
        public object SelectElements(Type typeValue)
        {
            return true;
        }

    }
}
