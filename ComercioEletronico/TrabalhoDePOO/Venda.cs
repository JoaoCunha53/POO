using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoDePOO.@internal;

namespace TrabalhoDePOO
{
    internal class Venda : IJobsVenda
    {

        /// <sumary>
        /// Atributos Class Venda
        /// </sumary>
        public int idVenda { get; set; }
        public Pessoa cliente { get; set; }
        public Artigo artigo { get; set; }
        public int quantidade { get; set; }
        public double preco { get; set; }
        public int estado { get; set; }
        public int exibir { get; set; }

        /// <summary>
        /// Construtor Class Vendas
        /// </summary>
        public Venda() { }
        public Venda(int idVenda, Pessoa cliente, Artigo artigo, int quantidade, double preco, int estado) 
        {
            this.idVenda = idVenda;
            this.cliente = cliente;
            this.artigo = artigo;
            this.quantidade = quantidade;
            this.preco = preco;
            this.estado = estado;
            this.exibir = 1;
        }
        /// <summary>
        /// Metodos Class Vendas
        /// </summary>
        public List<Venda> CarregarDados(string FilePath)
        {
            List<Venda> artigos = new List<Venda>();
            if (File.Exists(FilePath))
            {

                using (var reader = new StreamReader(FilePath))
                {
                    using (var csv = new CsvReader(reader,
                        new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        //var loadedRecords = csv.GetRecords<Person>().ToList();
                        artigos = csv.GetRecords<Venda>().ToList();

                    }
                }
            }
            return artigos;

        }
        public int GuardarDados(string FilePath, List<Venda> vendas)
        {
            try
            {
                // Serialização para CSV
                using (var writer = new StreamWriter(FilePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(vendas);
                }
                return 1;
            }
            catch { return 0; }
        }
        public void Adicionar(List<Venda> vendas, Pessoa cliente, List<Artigo> artigos)
        {
            int i = 0;
            Console.WriteLine("\nEncomendar Artigo");
            Console.Write("Id do artigo a encomendar: ");
                int index = artigos.FindIndex(a => a.idArtigo.Equals(int.Parse(Console.ReadLine())));
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            // Obtém o último índice registrado na lista
            int id = vendas.Count > 0 ? vendas.Count + 1 : 1;
            Venda venda = new Venda(id, cliente, artigos[index], quantidade, quantidade * artigos[index].precoUni, 0);

            vendas.Add(venda);
        }
        public void ListarEncomendasRealizadas(List<Venda> vendas, int idCliente)
        {
            Console.WriteLine("\nLista de Encomendas:");
            int i = -1;
            foreach (Venda venda in vendas)
            {
                i++;
                if (venda.cliente.idPessoa == idCliente && venda.exibir == 1)
                {
                    ListarEncomenda(venda);
                }
            }
            Console.WriteLine("\n");
        }
        public void ListarEncomendas(List<Venda> vendas)
        {
            Console.WriteLine("\nLista de Encomendas:");
            int i = -1;
            foreach (Venda venda in vendas)
            {
                ListarEncomenda(venda);
            }
            Console.WriteLine("\n");
        }
        public void ListarEncomenda(Venda venda)
        {
            if (venda.exibir == 1)
            {
                Console.WriteLine($"\n ENCOMENDA - {venda.idVenda}");
                Console.WriteLine($"\nId Cliente: {venda.cliente.idPessoa}" +
                   $"\nNome: {venda.cliente.nomeCompleto}" +
                   $"\nData Nascimento: {venda.cliente.dataNascimento}" +
                   $"\nNºTelefone: {venda.cliente.nTelemovel}" +
                   $"\nNif: {venda.cliente.nif}" +
                   $"\nMorada: {venda.cliente.morada}");
                Console.WriteLine($"\n|-- Artigo --|" +
                        $"\n    Id Artigo: {venda.artigo.idArtigo}" +
                        $"\n    Modelo: {venda.artigo.modelo.nameModelo}" +
                        $"\n    Marca: {venda.artigo.modelo.marca.nomeMarca}" +
                        $"\n    Descrição: {venda.artigo.modelo.descricao}" +
                        $"\n    Categoria: {venda.artigo.categoria.descr}" +
                        $"\n    Garantia: {venda.artigo.garantia.tipoGarantia} Validade: {venda.artigo.garantia.validade}" +
                        $"\n    Preço Unidade: {venda.artigo.precoUni}");
                Console.WriteLine($"    Quantidade encomendada: {venda.quantidade}");
                Console.WriteLine($"    Preço Total: {venda.preco}");
                string estado = "";
                if (venda.estado == 0) { estado = "Em processo"; }
                if (venda.estado == 1) { estado = "Enviado"; }
                if (venda.estado == 2) { estado = "Entrege"; }
                Console.WriteLine($"Estado: {estado}");
            }
        }
        public void Editar(List<Venda> vendas)
        {
            Console.WriteLine("\nEditar Encomenda:");
            Console.Write("\n Qual é i ID Encomenda:");
            int id = int.Parse(Console.ReadLine());
            int index = vendas.FindIndex(v => v.idVenda.Equals(id));
            bool inOut = true;
            while (inOut)
            {
                ListarEncomenda(vendas[index]);
                Console.WriteLine($"1 - Quantidade encomendada: {vendas[index].quantidade}");
                Console.WriteLine($"2 - Estado: {estado}");

                Console.Write("\nSelecione o campo para editar: ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        inOut = false;
                        break;
                    case 1:
                        Console.Write("\nQuantidae: ");
                        vendas[index].quantidade = int.Parse(Console.ReadLine());
                        vendas[index].preco = vendas[index].artigo.precoUni * vendas[index].quantidade;
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write($"\nEstado:{estado} ");
                        bool aux = true;
                        while(aux)
                        {
                            Console.WriteLine("\n1 - (Em processo)");
                            Console.WriteLine("2 - (Enviado)");
                            Console.WriteLine("3 - (Entrege)");
                            Console.Write("Selecione uma das opções:");
                            int op = int.Parse(Console.ReadLine());
                            switch(op)
                            {
                                case 1:
                                    vendas[index].estado = 0;
                                    aux = false;
                                    break;
                                case 2:
                                    vendas[index].estado = 1;
                                    aux = false;
                                    break;
                                case 3:
                                    vendas[index].estado = 2;
                                    aux = false;
                                    break;
                                default:
                                    Console.WriteLine("Valor selecionado é invalido.");
                                    break;
                            }
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Valor selecionado é invalido.");
                        break;

                }
            }
            Console.WriteLine("\n");

        }
        public void Remover(List<Venda> vendas)
        {
            Console.WriteLine("\nOcultar Venda:");
            Console.Write("Id da venda a ser excluída: ");
            int id = int.Parse(Console.ReadLine());
            int index = vendas.FindIndex(v => v.idVenda.Equals(id));

            if (index >= 0)
            {
                vendas[index].exibir = 0;
                Console.WriteLine("Venda ocultada com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Nenhuma venda ocultada.");
            }
            Console.WriteLine("\n");
        }
    }
}
