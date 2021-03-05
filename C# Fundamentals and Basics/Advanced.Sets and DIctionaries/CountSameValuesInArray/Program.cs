using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            foreach (var currentNumber in input)
            {
                if (!dictionary.ContainsKey(currentNumber))
                {
                    dictionary.Add(currentNumber, 0);
                }
                dictionary[currentNumber]++;
            }

            foreach (var (key, value) in dictionary)
            {
                Console.WriteLine($"{key}-{value}times");
            }

            //double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            //Dictionary<double, int> dictionary = new Dictionary<double, int>();

            //foreach (var el in input)
            //{
            //    if(!dictionary.ContainsKey(el))
            //    {
            //        dictionary.Add(el, 0);
            //    }
            //    dictionary[el]++;
            //}

            //foreach (var (key,value) in dictionary)
            //{
            //    Console.WriteLine($"{key}-{value}");
            //}
        }
    }
}
