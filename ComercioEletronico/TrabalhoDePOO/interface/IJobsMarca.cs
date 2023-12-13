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
    internal interface IJobsMarca
    {

        public List<Marca> CarregarDados(string FilePath);
        public int GuardarDados(string FilePath, List<Marca> marcas);
        public void AdicionarMarca(List<Marca> marcas);
        public void ListarMarca(List<Marca> marcas);
        public void EditarMarca(List<Marca> marcas);
        public void RemoverMarca(List<Marca> marcas);

    }
}
