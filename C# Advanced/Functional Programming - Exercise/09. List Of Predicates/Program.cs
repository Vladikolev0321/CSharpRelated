using System;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Predicate<int> isDivisable = new Predicate<int>((n) 
                => dividers.All(d => n % d == 0));

            Action<int, int[]> FindDivisableNums = new Action<int, int[]>((n, dividers) =>
             {
                 for (int i = 1; i <= n; i++)
                 {
                     if (isDivisable(i))
                     {
                         Console.Write(i + " ");
                     }
                 }
             });

            FindDivisableNums(n, dividers);
        }
    }
}
