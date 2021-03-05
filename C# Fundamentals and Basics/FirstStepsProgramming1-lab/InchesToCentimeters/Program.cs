using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double res = num * 2.54;
            Console.WriteLine(res);
               
        }
    }
}
