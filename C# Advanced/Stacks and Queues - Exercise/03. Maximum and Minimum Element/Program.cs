using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int[] cmdArgs = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                switch(cmdArgs[0])
                {
                    case 1:
                        stack.Push(cmdArgs[1]);
                        break;
                    case 2:
                        if (stack.Any())
                        {
                        stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Any())
                        {
                        Console.WriteLine(stack.Max());
                        }
                        break;

                    case 4:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;

                }


            }

            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
