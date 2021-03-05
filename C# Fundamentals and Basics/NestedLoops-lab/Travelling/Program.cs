using System;
using System.Diagnostics.CodeAnalysis;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while(destination != "End")
            {
                double sum = 0;
                double neededSum = double.Parse(Console.ReadLine());
                while(sum<neededSum)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    sum += savedMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
