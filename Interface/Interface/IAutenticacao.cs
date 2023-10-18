using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IAutenticacao
    {
        bool LogIn(string utilizador, string password);
        void LogOut();

    }
}
