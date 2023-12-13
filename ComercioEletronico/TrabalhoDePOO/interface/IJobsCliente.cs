using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO.@internal
{
    internal interface IJobsCliente
    {

        public List<Pessoa> CarregarDados(string FilePath);
        public int GuardarDados(string FilePath, List<Pessoa> clientes);
        public void Adicionar(List<Pessoa> clientes, string email, string chave);
        public void ListarClientes(List<Pessoa> clientes);
        public void Editar(Pessoa pessoas);
        public void Remover(List<Pessoa> clientes);

    }
}
