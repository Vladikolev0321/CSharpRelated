using System;
using System.Collections.Generic;
using System.Linq;

namespace CountUpperCaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console
                .ReadLine()
                .Split()
                .Where(word => char.IsUpper(word[0]))
                .ToList()
                .ForEach(Console.WriteLine);
                



        }
    }
}
