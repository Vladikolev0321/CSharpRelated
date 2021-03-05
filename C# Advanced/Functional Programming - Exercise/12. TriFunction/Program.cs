using System;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split();

            Func<string, int, bool> isValidWord = ((name, sum) => name.ToCharArray()
            .Select(ch => (int)ch).Sum() >= sum);

            Func<string[], int, Func<string, int, bool>, string> firstValidName =
                (arr, sum, func) => arr.FirstOrDefault(str => func(str,sum));

            var result = firstValidName(names, targetSum, isValidWord);
            Console.WriteLine(result);

        }
    }
}
