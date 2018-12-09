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
            var produtos = new Produto().Listar();

            // Skip e Take
            // Take - pega numero 'x' de registros
            // Skip - pula um numero 'x' de registros
            var produtosPaginados = produtos.Skip(1).Take(2);

            // Count - numero de registros
            int qtdeProdutos = produtos.Count();
            int qtdeProdutosComLetraA = produtos.Count(p => p.Nome.Contains("A"));

            // Single - Retorna o primeiro registro e lança uma exceção caso tenha mais de um registro que atenda sua condição
            var produtoSingle = produtos.SingleOrDefault(x => x.Nome.Contains("A"));

            // SkipWhile - pula enquanto a condição for verdadeira
            var produtosCaros = produtos.SkipWhile(x => x.Valor > 1000).ToList();


            // Union - Semelhante ao AddRange porem é removido os repetidos
            int[] vet1 = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] vet2 = {10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
            IEnumerable<int> union = vet1.Union(vet2);

            // Distinct - Remove os valores repetidos
            int[] vet3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var res = vet3.Distinct();

        }
    }
}
