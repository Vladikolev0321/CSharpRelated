using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 |4 5 6 |  7  8
            // string[] input = Console.ReadLine().Split("|").ToArray();

            // Console.WriteLine(string.Join(" ",input));
            //Console.WriteLine(input[0]);
            //Console.WriteLine(input[1]);
            //Console.WriteLine(input[2]);


            //List<int> list = Console.ReadLine().Split("|").Select(int.Parse).ToList();

            List<string> input = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> numbers = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                numbers.AddRange(input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }
           // numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
