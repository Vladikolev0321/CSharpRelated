using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var  periodicTable = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < cmdArgs.Length; j++)
                {
                    string currElem = cmdArgs[j];
                    periodicTable.Add(currElem);
                }
            }
            //periodicTable = periodicTable
            //    .OrderBy(x => x)
            //    .ToHashSet();

            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
