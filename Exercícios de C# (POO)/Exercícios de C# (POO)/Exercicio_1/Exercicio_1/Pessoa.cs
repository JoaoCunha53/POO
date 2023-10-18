using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Pessoa
    {
        //Atributos privados
        private string nome { get; set; }
        private int idade { get; set;}

        //Construtor
        public Pessoa()
        {
            this.nome = "Sem Nome";
            this.idade = -1;
        }
        public Pessoa(string nome)
        {
            this.nome = nome;
            this.idade = -1;
        }
        public Pessoa(int idade)
        {
            this.nome = "Sem Nome";
            this.idade = idade;
        }

        public Pessoa(string nome, int idade) 
        {
            this.nome = nome;
            this.idade = idade;
        }

        //Metodos 
        public void verInfo()
        {
            Console.WriteLine("\nNome:{0}\nIdade:{1}",nome,idade);
        }

    }
}
