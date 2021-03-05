using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var result = new Stack<string>(input.Reverse());
                
            while(result.Count>1)
            {
                var firstnumber = int.Parse(result.Pop());
                var operation = result.Pop();
                var secondnumber = int.Parse(result.Pop());

                var tempRes = 0;
                switch(operation)
                {
                    case "+":
                        tempRes = firstnumber + secondnumber;
                        break;
                    case "-":
                        tempRes = firstnumber - secondnumber;
                        break;
                }
                result.Push(tempRes.ToString());
            }
            Console.WriteLine(result.Pop());
        }
    }
}
