using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(input);

            string command;
            while((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split();
                if(cmdArgs[0] == "add")
                { 
                    int firstNum = int.Parse(cmdArgs[1]);
                    int secondNum = int.Parse(cmdArgs[2]);

                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else
                {
                    int n = int.Parse(cmdArgs[1]);

                    if(stack.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {                            
                                stack.Pop();                                
                        }

                    }

                }
            }

            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");


        }
    }
}
