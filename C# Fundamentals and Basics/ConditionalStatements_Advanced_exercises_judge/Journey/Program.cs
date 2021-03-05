using System;
using System.Security.Cryptography;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //Camp Hotel
            // Bulgaria Balkans Europe
            string destination = "";
            double moneyNeed = 0;
            string typeHoliday = "";


            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    moneyNeed = budget * 0.3;
                    typeHoliday = "Camp";
                }
                else
                {                   
                 moneyNeed = budget * 0.7;
                    typeHoliday = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    moneyNeed = budget * 0.4;
                    typeHoliday = "Camp";
                }
                else
                {
                    moneyNeed = budget * 0.8;
                    typeHoliday = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                moneyNeed = budget * 0.9;
                typeHoliday = "Hotel";
             
                   
               
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeHoliday} - { moneyNeed:F2}");
        }
    }
}
