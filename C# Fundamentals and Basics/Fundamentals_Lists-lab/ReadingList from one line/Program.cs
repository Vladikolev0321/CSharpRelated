using System;
using System.Collections.Generic;
using System.Linq;

namespace ReadingList_from_one_line
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            PrintList(list);

        }
        static void PrintList(List<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
