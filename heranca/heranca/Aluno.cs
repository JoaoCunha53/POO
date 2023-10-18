using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{

    internal class Aluno : Pessoa 
    {
        //Atributos
        public string Matricula { get; set; }
        public string Curso { get; set; }

        //Construtor
        public Aluno(string nome , int idade , string matricula , string curso) : base(nome, idade) {
            Matricula = matricula;
            Curso = curso;
            }

        //Funcao / Processo
        public void Estudar()
        {
            Console.WriteLine("0 {0} está a estudar a UC {1} e tem a matricula {2}",Nome,Curso,Matricula);
        }

    }
}
