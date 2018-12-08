using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Entity;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numerosPares = {2, 4, 6, 8, 10};
            int[] numerosImpares = {1, 3, 5, 7, 9};
            int[] numerosMisturados = {1, 2, 3, 4};

            // Intersect - compara listas ou registros e traz os encontrados
            // Verificamos se numerosMisturados tem numerosPares e retorna a lista dos encontrados
            var numerosEmComum = numerosMisturados.Intersect(numerosPares);

            // Except - compara listas ou registros e traz apenas os unicos
            var numerosQueNaoSeRepetem = numerosMisturados.Except(numerosPares);

            // Range - Cria uma lista partindo de uma sequencia
            var sequencia = Enumerable.Range(10, 3);

            // Repeat - Cria uma lista com determinado item repetido
            var repetir = Enumerable.Repeat("Will", 3);

            //////////////////////////////////////////////////////////////////////////////////////

            var produtos1 = new Produto().Listar();
            var produtos2 = new List<Produto>
            {
                new Produto() {Nome = "Galaxy", Valor = 2500},
                new Produto() {Nome = "Iphone X", Valor = 7900}
            };

            // AddRange - Somando as duas listas
            produtos1.AddRange(produtos2);

            produtos1.ForEach(p => Console.WriteLine(p.Nome));
            Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////////////////

            var produtos = new Produto().Listar();

            // Any - verifica se existe, se existir retorna true
            // Any - aceita lambda
            if (produtos.Any(p => p.Quantidade > 10))
            {
                Console.WriteLine("Há itens");
                Console.ReadKey();
            }

            // FirstOrDefault - retorna nulo
            var produto1 = produtos.FirstOrDefault();

            // First - não retorna nulo
            var produto2 = produtos.First();

            // LastOrDefault - retorna nulo
            var produto3 = produtos.LastOrDefault();

            // Last - não retorna nulo
            var produto4 = produtos.Last();

        }
    }
}
