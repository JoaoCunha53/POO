using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Pessoa
    {
        //Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Construtor
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Apresentar()
        {
            Console.WriteLine("Olá, eu sou {0} e tenho {1} anos"
                , Nome, Idade);
        }
    }


}
