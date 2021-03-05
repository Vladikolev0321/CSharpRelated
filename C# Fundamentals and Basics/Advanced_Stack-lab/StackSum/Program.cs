using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(numbers);

            while(true)
            {
                string[] command = Console.ReadLine()
                    .ToLower()
                    .Split();
                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));

                }
                else if (command[0] == "remove")
                {
                    int totalElementsToRemove = int.Parse(command[1]);

                    if (stack.Count >= totalElementsToRemove)
                    {

                        for (int i = 0; i < totalElementsToRemove; i++)
                        {
                            if (stack.Any())
                            {
                                stack.Pop();
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Sum:{stack.Sum()} ");
        }
    }
}
