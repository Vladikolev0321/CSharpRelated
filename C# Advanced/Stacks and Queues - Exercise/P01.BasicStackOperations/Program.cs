using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.BasicStackOperations
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

            Stack<int> stack = new Stack<int>(numbers);

            //for(int i = 0; i < N; i++)
            //{
            //    stack.Push(numbers[i]);
            //}
            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }


            if (!stack.Any())
            {
                Console.WriteLine(0);
            }
            else if(stack.Any(n => n == X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
               
        }
    }
}
