using System;
using System.Collections.Generic;

namespace Stacks_and_Queues_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new Stack<string>();

            myStack.Push("First");
            myStack.Push("Second");
            myStack.Push("Third");

            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Peek());

            var stack = new Stack<int>();



        }
    }
}
