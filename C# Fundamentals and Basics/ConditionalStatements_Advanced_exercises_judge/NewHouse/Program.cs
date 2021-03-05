using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlower = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double moneyNeeded = 0.00;

            if (typeFlower == "Roses")
            {
                moneyNeeded = countFlowers * 5;
                if (countFlowers > 80)
                {
                    moneyNeeded = moneyNeeded - moneyNeeded * 0.1;
                }

            }
            else if (typeFlower == "Dahlias")
            {
                moneyNeeded = countFlowers * 3.80;
                if (countFlowers > 90)
                {
                    moneyNeeded = moneyNeeded - moneyNeeded * 0.15; 
                }
            }
            else if(typeFlower == "Tulips")
            {
                moneyNeeded = countFlowers * 2.80;
                if (countFlowers > 80)
                {
                    moneyNeeded = moneyNeeded - moneyNeeded * 0.15;
                }
//Console.WriteLine(moneyNeeded);
            }
            else if(typeFlower == "Narcissus")
            {
                moneyNeeded = countFlowers * 3;
                if (countFlowers < 120)
                {
                    moneyNeeded = moneyNeeded + moneyNeeded * 0.15; 
                }

            }
            else if(typeFlower == "Gladiolus")
            {
                moneyNeeded = countFlowers * 2.5;
                if (countFlowers < 80)
                {
                    moneyNeeded = moneyNeeded + moneyNeeded * 0.2;
                }

            }

            
            if(budget>=moneyNeeded)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {typeFlower} and {budget - moneyNeeded:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyNeeded-budget:F2} leva more.");
            }
        }
    }
}
