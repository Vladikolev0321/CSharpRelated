using System;
using System.Linq;

namespace Order_By
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            input = input
                .OrderBy(x => x[0])
                .ThenByDescending(x => x.Length)
                .ToList();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
