using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Shop.Domain.Entity;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var frutas = new Produto().ListarFrutas();
            var eletronicos = new Produto().Listareletronicos();

            var produtosList = new List<Produto>();
            produtosList.AddRange(frutas);
            produtosList.AddRange(eletronicos);


            produtosList.ForEach(p =>
            {
                Console.WriteLine(JsonConvert.SerializeObject(p));
            });

            var resultado1 = produtosList.Where(p => p.Categoria.Equals("Eletronicos")).Max(x => x.Valor);

            // into - apelido para o agrupamento
            // from in - apelido da tabela
            var resultado2 = (from p in produtosList
                             group  p by p.Categoria into grupo
                             select new ProdutoCategoria
                             {
                                 NomeDaCategoria = grupo.Key,
                                 ValorMininmo = grupo.Min(x => x.Valor),
                                 ValorMaximo = grupo.Max(x => x.Valor),
                                 ValorTotal = grupo.Sum(x => x.Valor)
                             }).OrderBy(x => x.NomeDaCategoria); // Possivel utilizar o OrderBy juntamente com a expressão


             Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////////

            var produtos = new Produto().ListarFrutas();

            // Max - traz o valor do maior item
            var valorMaior = produtos.Max(x => x.Valor);

            // Max - traz o valor do maior item
            var valorMenor = produtos.Min(x => x.Valor);

            // Average - Faz a media de itens
            var mediaValor = produtos.Average(x => x.Valor);

            // Sum - Faz a soma
            var somaValor = produtos.Sum(x => x.Valor);

        }
    }
}
