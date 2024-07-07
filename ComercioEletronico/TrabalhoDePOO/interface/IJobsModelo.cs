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
    internal interface IJobsModelo
    {

        public List<Modelo> CarregarDados(string FilePath);
        public int GuardarDados(string FilePath, List<Modelo> modelo);
        public void AdicionarModelo(List<Modelo> modelos, List<Marca> marcas);
        public void ListarModelo(List<Modelo> modelos);
        public void EditarModelo(List<Modelo> modelos, List<Marca> marcas);
        public void RemoverModelo(List<Modelo> modelos);

    }
}
