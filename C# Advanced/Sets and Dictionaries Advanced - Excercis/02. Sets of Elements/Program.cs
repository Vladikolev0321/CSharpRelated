using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cmdArgs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = cmdArgs[0];
            int m = cmdArgs[1];

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set1.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set2.Add(num);
            }

            foreach (var num in set1)
            {
                if(set2.Any(n => n == num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
