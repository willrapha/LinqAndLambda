using System;
using System.Linq;
using Shop.Domain.Entity;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Where
            var produtos = new Produto().Listar().Where(p => p.Valor > 4);
            foreach (var item in produtos)
            {
                Console.WriteLine(item.Nome);
            }

            // ForEach
            // Unica operação
            new Produto().Listar().ForEach(p => Console.WriteLine(p.Nome));

            // Para mais de uma operação colocar tudo entre chave
            new Produto().Listar().ForEach(p =>
                {
                    Console.WriteLine(p.Nome);
                    Console.WriteLine(p.Valor);
                }
            );

            // o Where retorna um IEnumerable por isso utilizamos o .ToList() devido o ForEach aceitar apenas List
            new Produto().Listar().Where(p => p.Valor > 4).ToList().ForEach(p =>
                {
                    Console.WriteLine(p.Nome);
                    Console.WriteLine(p.Valor);
                }
            );

            Console.ReadKey();
        }
    }
}
