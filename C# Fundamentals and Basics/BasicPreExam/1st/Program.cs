using System;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBees = int.Parse(Console.ReadLine());
            int countFlowers = int.Parse(Console.ReadLine());

            double allHoney = countBees * countFlowers * 0.21;
            double countPiti = allHoney / 100;
            double unusedHoney = allHoney % 100;

            Console.WriteLine($"{Math.Floor(countPiti)} honeycombs filled.");
            Console.WriteLine($"{unusedHoney:F2} grams of honey left.");
        }
    }
}
