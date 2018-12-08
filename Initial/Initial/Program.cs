using System;
using System.Linq;

namespace Initial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Where
            foreach (int number in numbers.Where(n => n > 4))
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
