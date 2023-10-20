using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAbstrata
{
    internal abstract class Veiculo
    {
        //Propriedades
        public string Marca { get; set; }
        public string Modelo { get; set; }

        //Construtor
        public Veiculo(string marca, string modelo) 
        {
            Marca = marca;
            Modelo = modelo;
        }

        //Método abstrato que deve ser implementado nas subclasses
        public abstract void Mover();
        
        public void LigarMotor()
        {
            Console.WriteLine("O motor está ligado");
        }



    }
}
