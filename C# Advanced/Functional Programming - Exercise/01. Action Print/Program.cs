using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split();

            Action<string> printString = Console.WriteLine;

            names
                .ToList()
                .ForEach(printString);

        }
        
    }
}
