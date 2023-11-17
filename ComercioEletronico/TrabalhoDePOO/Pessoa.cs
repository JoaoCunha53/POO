using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
﻿using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal class Pessoa
    {
        ///<summary>
        ///Atributos Class Clientes
        ///</summary>
        public int idPessoa { get; set; }
        public string nomeCompleto { get; set; }
        public DateOnly dataNascimento { get; set; }
        public decimal nif { get; set; }
        public decimal nTelemovel { get; set; }
        public string email { get; set;}
        public string chave { get; set; }
        public string morada { get; set;}

        public int funcao { get; set; }

        ///<summary>
        ///Construtor Class Cliente 
        /// </summary>
        /// 

        public Pessoa() { }
        public Pessoa(int idPessoa, string nomeCompleto, DateOnly dataNascimento, decimal nif,
            decimal nTelemovel, string morada, string email, string chave,int funcao)
        {
            this.idPessoa = idPessoa;
            this.nomeCompleto = nomeCompleto;
            this.dataNascimento = dataNascimento;
            this.nif = nif;
            this.nTelemovel = nTelemovel;
            this.morada = morada;
            this.email = email;
            this.chave = chave;
            this.funcao = funcao;
        }

    }

}
