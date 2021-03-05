using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var modifiedList = list
                .Where(x => x > list.Average())
                .OrderByDescending(x => x)
                .Take(5)
                .ToList();

            if (modifiedList.Any())
            {
                Console.WriteLine(string.Join(' ', modifiedList));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
