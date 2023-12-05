using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasBancarias
{
    interface IOperacoes
    {
        bool InsertElement(object x);
        bool RemoveElement(object x);
        bool UpdateElement(object x);
        object SelectElements(Type typeValue);


    }
}
