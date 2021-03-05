using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToList();

            //List<int> sortedNums = nums.OrderByDescending(x => x)
            //    .ToList();


            ////OTHER WAY
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x=>x)
                .Take(3)
                .ToList();

            //for (int i = 0; i < 3 && i<sortedNums.Count; i++)
            //{
               
            //    Console.Write($"{sortedNums[i]} ");

            //}
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
