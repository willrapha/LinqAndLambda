using System;
using System.Linq;

namespace Initial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Numeros
            int[] numbers = { 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Linq
            // from - num - Apelido
            // numbers - Array ou tabela
            // select - faz a consulta
            var result = from num in numbers
                         where num > 4
                         orderby num
                         select num;

            // Linq e Lambda
            // Where, OrderBy
            var result2 = numbers.Where(n => n > 4).OrderBy(n => n);

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }

            // Textos
            string[] colors = { "Preto", "Branco", "Verde", "Vermelho", "Azul" };

            var resultColor = colors.Where(x => x.Contains("e") && x.Contains("v"));

            foreach(string color in resultColor)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}
