using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cmdArgs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int N = cmdArgs[0];
            int S = cmdArgs[1];
            int X = cmdArgs[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            if (!queue.Any())
            {
                Console.WriteLine(0);
            }
            else if(queue.Any(n => n == X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }

        }
    }
}
