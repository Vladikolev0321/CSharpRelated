using System;
using System.Collections.Generic;

namespace _02.RandomiseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                int index = random.Next(0, input.Length);
                string temp = input[i];
                input[i] = input[index];
                input[index] = temp;
              //  Console.WriteLine(input[index]);
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
