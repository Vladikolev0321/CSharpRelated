using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split();

            var result = new Stack<string>(input.Reverse());

            while(result.Count > 1)
            {
                var firstNumber = int.Parse(result.Pop());
                var operation = result.Pop();
                var secondNumber = int.Parse(result.Pop());

                var tempResult = 0;

                switch (operation)
                {
                    case "+":
                        tempResult = firstNumber + secondNumber;
                        break;
                    case "-":
                        tempResult = firstNumber - secondNumber;
                        break;
                }

                result.Push(tempResult.ToString());
            }

            Console.WriteLine(result.Pop());

        }
    }
}
