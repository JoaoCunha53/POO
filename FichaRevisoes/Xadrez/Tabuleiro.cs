using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez
{
    internal class Tabuleiro
    {
        private string[,] tabuleiro { get; set; }

        public Tabuleiro()
        {
            tabuleiro = new string[8, 8];
            tabuleiro[1, 3] = "Bispo";
            tabuleiro[7, 3] = "Bispo";
        }

        public void ColocarPeças(int linha, int coluna,string peca)
        {
            if(linha > 7 || coluna > 7) 
            {
                Console.WriteLine("Possição invalida");
            }
            else
            {
                if(tabuleiro[linha, coluna] == null) 
                {
                    tabuleiro[linha, coluna] = peca;
                }
            }
        }

        public void VerificarPossicao(int linha, int coluna)
        {
            if (linha > 7 || coluna > 7)
            {
                Console.WriteLine("Possição invalida");
            }
            else
            {
                if (tabuleiro[linha, coluna] != null)
                {
                    Console.WriteLine("Posição ocupada por {0}", tabuleiro[linha, coluna]);
                }
                else
                {
                    Console.WriteLine($"A posição {linha},{coluna} não está ocupada.");
                }
            }

        }

        public void ProcurarPocicaoDasPeças(string peca)
        {
            for(int i=0; i<= 7; i++)
            {
                for (int o = 0; o <= 7; o++)
                {
                    if(peca == tabuleiro[i,o])
                    {
                        Console.WriteLine($"A peça {peca}, encontasse na posição {i},{o}.  ");
                    }
                }
            }
        }
    }
}
