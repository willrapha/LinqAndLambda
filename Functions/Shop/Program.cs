using System;
using System.Linq;
using Newtonsoft.Json;
using Shop.Domain.Entity;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = new Produto().Listar();

            // Select
            var nomes = produtos.Select(p => p.Nome);
            var produtoSimples = produtos.Select(p => new ProdutoSelecionado { Name = p.Nome, Value = p.Valor, DiaVencimento = p.DataVencimento.Day });

            // Substring - ps.Name.Substring(1,2)
            // Insert - ps.Name.Insert(2, "Will")
            // Remove - ps.Name.Remove(2,2)
            // Replace - ps.Name.Replace("a","z")
            produtoSimples.ToList().ForEach(ps => Console.WriteLine(ps.Name.Replace("a","z")));

            // o Where retorna um IEnumerable por isso utilizamos o .ToList() devido o ForEach aceitar apenas o tipo List
            // StartsWith - começa com
            // EndsWith - termina com
            produtos.Where(p => p.Nome.StartsWith("A") || p.Nome.EndsWith("o")).ToList().ForEach(p =>
                {
                    // JsonConvert - pacote Install-Package Newtonsoft.Json
                    Console.WriteLine(JsonConvert.SerializeObject(p));
                    Console.WriteLine();
                }
            );

            // Filtro por dia - p.DataVencimento.Day > 3
            // Ano - p.DataVencimento.Year == 2018
            produtos.Where(p => p.DataVencimento.Year == (DateTime.Now.Year + 1)).ToList().ForEach(p =>
                {
                    Console.WriteLine(JsonConvert.SerializeObject(p));
                    Console.WriteLine();
                }
            );

            Console.ReadKey();
        }
    }
}
