using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace SerializacaoCSV
{
    internal class Pessoa
    {
        [Name("nome")]
        public string Nome { get; set; }

        [Name("idade")]
        public int Idade { get; set; }

        //Construtor
        public Pessoa(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }

    }
}
