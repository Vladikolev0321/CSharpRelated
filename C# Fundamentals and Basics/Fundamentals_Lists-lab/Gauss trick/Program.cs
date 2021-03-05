using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            GausTrick(list);

        }
        static void GausTrick(List<int> list)
        { 

            for (int i = 0,j = list.Count-1; i < list.Count/2; i++, j--)
            {
                Console.Write($"{list[i] + list[j]} ");
            }
            if(list.Count % 2 != 0)
            {
                Console.Write(list[list.Count / 2]);
            }
        }
    }
}
