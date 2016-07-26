using System;
using System.Linq;

namespace Nums
{
    /*
     * Есть коллекция чисел и отдельное число Х. Надо вывести все пары чисел, которые в сумме равны заданному Х.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            // Случайная последовательность чисел.
            var seq = Enumerable.Repeat(0, 100).Select(i => random.Next(1000)).ToArray();
            // Заданное число.
            var n = random.Next(1000);

            Console.WriteLine("N: {0}", n);
            for (var i = 0; i < seq.Length; i++)
            {
                for (var j = 0; j < seq.Length; j++)
                {
                    if (n == (seq[i] + seq[j]))
                    {
                        Console.WriteLine("{0}, {1}", seq[i], seq[j]);
                    }
                }
            }
        }
    }
}
