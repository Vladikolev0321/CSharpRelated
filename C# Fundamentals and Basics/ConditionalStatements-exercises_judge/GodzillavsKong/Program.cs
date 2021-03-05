using System;

namespace GodzillavsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStatist = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double deckorPrice = budget * 0.1;
            if(countStatist > 150 )
            {
                priceClothes = priceClothes - priceClothes * 0.1;
            }

             double  moneyNeeded = countStatist * priceClothes + deckorPrice ; 
             if(moneyNeeded > budget)
             {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded - budget:F2} leva more.");
             
             }
             else
             {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - moneyNeeded:F2} leva left.");
             }
            
        }
    }
}
