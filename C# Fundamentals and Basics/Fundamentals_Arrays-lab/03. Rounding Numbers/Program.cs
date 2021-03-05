using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] realarr = new int[arr.Length];
            for (int i = 0; i < realarr.Length; i++)
            {
                realarr[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);

            }
            for (int i = 0; i < realarr.Length; i++)
            {
                    Console.WriteLine($"{arr[i]} => {realarr[i]}");
                  //Console.WriteLine(string.Join("=> ", realarr));
            }
        }
    }
}
