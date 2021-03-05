using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<string> printString = Console.WriteLine;

            //string[] names = Console.ReadLine()
            //    .Split();

            //names
            //    .Select(n => "Sir " + n)
            //    .ToList()
            //    .ForEach(printString);

            Action<string> printString = (name) =>
            {
                Console.WriteLine("Sir " + name);
            };

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(printString);





                
        }
    }
}
