using System;

namespace SupppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPen = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            double litre = double.Parse(Console.ReadLine());
            int countSale = int.Parse(Console.ReadLine());

            double neededMoney = countPen * 5.80 + countMarkers * 7.20 + litre * 1.20;
            neededMoney = neededMoney - ((neededMoney * countSale) / 100);
            Console.WriteLine($"{neededMoney:F3}");
        }
    }
}
