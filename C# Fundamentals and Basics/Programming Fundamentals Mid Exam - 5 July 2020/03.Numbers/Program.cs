using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            double average = list.Average();

            var modifiedList = new List<int>();
            foreach (var item in list)
            {
                if(item > average)
                {
                    modifiedList.Add(item);
                }
            }
            if (modifiedList.Any())
            {
                modifiedList = modifiedList
                    .OrderByDescending(x => x)
                    .Take(5)
                    .ToList();

                Console.WriteLine(string.Join(' ', modifiedList));
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
