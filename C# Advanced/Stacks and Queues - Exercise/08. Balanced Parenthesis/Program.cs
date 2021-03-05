using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthessStack = new Stack<char>();
            foreach (var symbol in input)
            {
                if (parenthessStack.Any())
                {
                    char check = parenthessStack.Peek();
                    if(check == '{' && symbol == '}')
                    {
                        parenthessStack.Pop();
                        continue;
                    }
                    else if(check == '[' && symbol == ']')
                    {
                        parenthessStack.Pop();
                        continue;
                    }
                    else if(check == '(' && symbol == ')')
                    {
                        parenthessStack.Pop();
                        continue;
                    }

                }

                parenthessStack.Push(symbol);
            }

            Console.WriteLine(parenthessStack.Any() ? "NO" : "YES");
        }
    }
}
