using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFisherman = int.Parse(Console.ReadLine());

            double moneyNeeded = 0.0;

            switch(season)
            {
                case "Spring":
                    moneyNeeded = 3000;                 
                   
                    break;
                case "Summer":
                   
                   // break;

                case "Autumn":
                    moneyNeeded = 4200;
                 
                    break;

                case "Winter":
                    moneyNeeded = 2600;
                                  
                    break;
                
                  
            }
                if (countFisherman <= 6)
                {
                    moneyNeeded = moneyNeeded - moneyNeeded * 0.1;
                }
                else if (countFisherman >= 7 && countFisherman <= 11)
                {
                    moneyNeeded = moneyNeeded - moneyNeeded * 0.15;
                }
                else if (countFisherman >= 12)
                {
                    moneyNeeded = moneyNeeded - moneyNeeded * 0.25;
                }
            

                if (countFisherman % 2 == 0 && season!="Autumn")
                {
                moneyNeeded = moneyNeeded - moneyNeeded * 0.05;
                }
          //  Console.WriteLine(moneyNeeded);
            if (budget >= moneyNeeded)
            {
                Console.WriteLine($"Yes! You have {budget - moneyNeeded:F2} leva left.");
            }
            else if(budget < moneyNeeded)
            {
                Console.WriteLine($"Not enough money! You need {moneyNeeded - budget:F2} leva.");
            }

        }
    }
}
