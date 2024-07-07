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
    internal interface IJobsCampanha
    {
        public List<Campanha> CarregarDados(string FilePath);
        public int GuardarDados(string FilePath, List<Campanha> campanha);
        public void Adicionar(List<Campanha> campanhas);
        public void Listar(List<Campanha> campanhas);
        public void Editar(List<Campanha> campanhas);
        public void Remover(List<Campanha> campanhas);
    }
}
