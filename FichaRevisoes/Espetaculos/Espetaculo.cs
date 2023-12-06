using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espetaculos
{
    internal class Espetaculo
    {

        //Atributo
        private string sala { get; set; }
        private DateOnly data { get; set;}
        private TimeOnly time { get; set; }
        private int lugares { get; set; }
        private int lugaresDisponiveis { get; set; }

        //Construtor
        public Espetaculo() { }
        public Espetaculo(string sala, DateOnly data, TimeOnly time, int lugares, int lugaresDisponiveis) 
        {
            this.sala = sala;
            this.data = data;
            this.time = time;
            this.lugares = lugares;
            this.lugaresDisponiveis = lugaresDisponiveis;
        }

        //Metodos
        public Espetaculo RegistarEspetaculo()
        {
            Console.WriteLine("Identificação da Sala:");
            string sala = Console.ReadLine();
            Console.WriteLine("Qual é a Data a agendar (dd-MM-yyyy): ");
            DateOnly data = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a Hora (00:00): ");
            TimeOnly time = TimeOnly.Parse(Console.ReadLine());
            Console.WriteLine("Lotação maxima: ");
            int lugares = int.Parse(Console.ReadLine());
            Espetaculo esp = new Espetaculo(sala, data, time, lugares, lugares);
            return esp;
        }

        public void ListarEspetaculo(Espetaculo esp)
        {
            Console.WriteLine("Sala: {0}",esp.sala);
            Console.WriteLine("Data: {0}", esp.data);
            Console.WriteLine("Hora: {0}", esp.time);
            Console.WriteLine("Lotação maxima: {0}", esp.lugares);
            Console.WriteLine("Quantos lugares Disponiveis: {0}", esp.lugaresDisponiveis);
        }




    }
}
