using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDePOO.@interface
{
    internal interface IJobsArtigo
    {

        public List<Artigo> CarregarDados(string FilePath);
        public int GuardarDados(string FilePath, List<Artigo> artigos);
        public void Adicionar(List<Artigo> artigos, List<Modelo> modelos, List<Categoria> categorias, List<Garantia> garantias);
        public void Listar(List<Artigo> artigos);
        public void Editar(List<Artigo> artigos, List<Modelo> modelos, List<Categoria> categorias, List<Garantia> garantias);
        public void Remover(List<Artigo> artigos);

    }
}
