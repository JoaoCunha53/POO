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
        public int idCliente {  get; set; }
        public int idPessoa { get; set; }
        public string nomeCompleto { get; set; }
        public DateTime dataNascimento { get; set; }
        public decimal nif { get; set; }
        public decimal nTelemovel { get; set; }
        public string email { get; set;}
        public string morada { get; set;}

        ///<summary>
        ///Construtor Class Cliente 
        /// </summary>
        /// 

        public Pessoa() { }
        public Pessoa(int idPessoa, string nomeCompleto, DateTime dataNascimento, decimal nif,
            decimal nTelemovel, string email, string morada)
        {
            this.idPessoa = idPessoa;
            this.nomeCompleto = nomeCompleto;
            this.dataNascimento = dataNascimento;
            this.nif = nif;
            this.nTelemovel = nTelemovel;
            this.email = email;
            this.morada = morada;
        }

    }
}
