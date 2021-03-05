using System;
using System.Linq;

namespace P03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var cmdArgs = command
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                //string[] commandArgs = command.Split(" ");
                if (cmdArgs.Length > 1)
                {
                    //commandArgs = commandArgs.Skip(1).Split(",");
                    //command = commandArgs.Skip(1).ToString();
                    //var cmdArgs = command.Split(", ").Select(int.Parse);
                    var elements = cmdArgs.Skip(1).Select(int.Parse);

                    stack.Push(elements);
                }
                else if (cmdArgs[0] == "Push")
                {
                    int elemToPush = int.Parse(cmdArgs[1]);
                    stack.Push(elemToPush);
                }
                else if (command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            PrintStack(stack);
            PrintStack(stack);

        }

        private static void PrintStack(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
