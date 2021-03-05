using System;
using System.Globalization;

namespace Increment_Decrement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };
            Increment(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
        static void Increment(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
        }
    }
}
