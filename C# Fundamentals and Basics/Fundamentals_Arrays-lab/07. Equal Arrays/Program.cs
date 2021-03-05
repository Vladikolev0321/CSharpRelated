using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isEqual = false;
                    break;
                }
            }
            if (isEqual)
            { int sum = 0;
                foreach (var item in arr1)
                {
                    sum += item;
                }
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
