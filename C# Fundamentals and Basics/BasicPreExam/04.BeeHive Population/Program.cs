using System;

namespace _04.BeeHive_Population
{
    class Program
    {
        static void Main(string[] args)
        {
            double population = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            for (int i = 1; i <= years; i++)
            {
                //Console.WriteLine($"Godini{i}");
                population = population + Math.Floor(population / 10) * 2 ;
              //  Console.WriteLine($"Izlupeni:{population}");
                if(i % 5 == 0)
                {
                    population -= Math.Floor(population / 50) * 5;
                   // Console.WriteLine($"Imigraciq:{population}");

                }

                population = population - 2 * Math.Floor(population / 20);
               // Console.WriteLine($"Umrqli:{population}");

            }

            Console.WriteLine($"Beehive population: {population}");
        }
    }
}
