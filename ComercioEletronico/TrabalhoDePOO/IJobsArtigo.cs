using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO
{
    internal interface IJobsArtigo<T>
    {

        public List<T> CarregarDados(string FilePath);
        public int GuardarDados(string FilePath, List<T> artigos);
        public int GuardarDados(string FilePath, List<Garantia> Garantia);
        public void Adicionar(List<Artigo> artigos, List<Modelo> modelos, List<Categoria> categorias, List<Garantia> garantias);
        public void Listar(List<Artigo> artigos);
        public void Editar(List<Artigo> artigos, List<Modelo> modelos, List<Categoria> categorias, List<Garantia> garantias);
        public void Remover(List<T> artigos);

    }
}
