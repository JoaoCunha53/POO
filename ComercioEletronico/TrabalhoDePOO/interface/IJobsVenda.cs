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
    internal interface IJobsVenda
    {
        public List<Venda> CarregarDados(string FilePath);
        public int GuardarDados(string FilePath, List<Venda> vendas);
        public void Adicionar(List<Venda> vendas, Pessoa cliente, List<Artigo> artigos);
        public void ListarEncomendasRealizadas(List<Venda> vendas, int idCliente);
        public void ListarEncomendas(List<Venda> vendas);
        public void ListarEncomenda(Venda venda);
        public void Editar(List<Venda> vendas);
        public void Remover(List<Venda> vendas);
    }
}
