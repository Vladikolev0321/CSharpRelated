using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> isDivisable = new Predicate<int>((num) => num % n == 0);

            var ReverseAndRemovesDivisableNums = new Func<List<int>, List<int>>((list) =>
             {
                 list.Reverse();
                 for (int i = 0; i < list.Count; i++)
                 {
                     if (isDivisable(list[i]))
                     {
                         list.Remove(list[i]);
                         i--;
                     }
                 }
                 return list;
             });

            numbers = ReverseAndRemovesDivisableNums(numbers);
            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
