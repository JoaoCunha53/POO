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
    internal interface IJobsCategoria
    {
        public List<Categoria> CarregarDados(string FilePath);
        public int GuardarDados(string FilePath, List<Categoria> categorias);
        public void Adicionar(List<Categoria> categorias);
        public void Listar(List<Categoria> categorias);
        public void Editar(List<Categoria> categorias);
        public void Remover(List<Categoria> categorias);
       
    }
}
