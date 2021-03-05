using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P01.GenericBoxofString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> elements = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                elements.Add(element);

                //Box<int> box = new Box<int>(value);
                //Console.WriteLine(box);
            }
            Box<double> box = new Box<double>(elements);

            double elementToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.CountGreaterElements(elements,elementToCompare));


            //int[] indexesToSwap = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //box.SwapElementsByIndex(elements, indexesToSwap[0], indexesToSwap[1]);
            //Console.WriteLine(box);
        }
    }
}
