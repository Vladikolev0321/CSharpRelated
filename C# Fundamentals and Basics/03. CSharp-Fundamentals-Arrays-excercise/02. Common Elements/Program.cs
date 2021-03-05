using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
           // string input = Console.ReadLine();
           ////1
            //Console.WriteLine(string.Join(" ", arr1));
            /*foreach (var item in arr1)
            {
                Console.Write(item);
            }
            //Console.WriteLine(arr1[2]);
            */
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if(arr2[i] == arr1[j])
                    {
                        Console.Write($"{arr2[i]} ");
                    }
                }
            }


        }
    }
}
