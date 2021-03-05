using System;
using System.Linq;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            ///with Select
            int[] arrayByFive = arr
                .Select(x => x*5)
                .ToArray();
            ///with Where
            ///
            
            Console.WriteLine(string.Join(" ", arrayByFive));

             
        }
    }
}
