using System;
using System.Collections.Generic;
using System.Linq; 
namespace ReverseStrings
{   
    class Program
    {   
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            //Stack stack = new Stack();
            var stack = new Stack<char>();
            
            
            // Stack<int> stack = new;
           // Stack<int>();

            foreach(var ch in input)
            {
                stack.Push(ch);
            }
            ////without foreach to fill the stack use this
            //var stack = new Stack<char>(input);
            ////Even faster way is 
            //var stack = new Stack<char>(Console.ReadLine());

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            //Console.WriteLine();
            


        }
    }
}
