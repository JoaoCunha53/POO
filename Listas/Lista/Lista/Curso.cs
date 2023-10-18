using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Curso
    {

        public string Nome { get; set; }
        List<Aluno> listAlunos = new List<Aluno>();

        public Curso(string nome) 
        {
            Nome = nome;
        }

        public void AdicionarAluno(Aluno aluno)
        {
            listAlunos.Add(aluno);
        }
        public void ListarAlunos()
        {
            Console.WriteLine("Alunos matriculados no curso " + Nome + ":");
            foreach(var aluno in listAlunos)
            {
                Console.WriteLine("Nome: {0}, Matricula {1}", aluno.Nome, aluno.Matricula);
            }
        }

    }
}
