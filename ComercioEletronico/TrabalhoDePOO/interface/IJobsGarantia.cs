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
    internal interface IJobsGarantia
    {

        public List<Garantia> CarregarDados(string FilePath);
        public int GuardarDados(string FilePath, List<Garantia> Garantia);
        public void AdicionarGarantia(List<Garantia> garantia);
        public void ListarGarantia(List<Garantia> Garantias);
        public void EditarGarantia(List<Garantia> Garantias);
        public void RemoverGarantia(List<Garantia> Garantias);

    }
}
