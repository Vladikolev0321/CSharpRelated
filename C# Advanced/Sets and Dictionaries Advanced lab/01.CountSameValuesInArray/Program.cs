using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //-2.5 4 3 -2.5 -5.5 4 3 3 -2.5 3
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                double num = arr[i];
                if (!numbers.ContainsKey(num))
                {
                    numbers[num] = 0;
                }
                numbers[num]++;
            }

            foreach (var kvp in numbers)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }

        }
    }
}
