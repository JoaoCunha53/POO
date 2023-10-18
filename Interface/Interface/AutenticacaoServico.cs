using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class AutenticacaoServico : IAutenticacao
    {
        public bool LogIn(string usuario, string senha)
        {
            //Lógica de autenticão aqui
            //Por exemplo, verificar
            if(usuario == "123" && senha == "123") 
            {
                return true;            
            }
            else
            {
                return false;
            }
        }
        public void LogOut()
        {
            Console.WriteLine("logOut");
        }

    }
}
