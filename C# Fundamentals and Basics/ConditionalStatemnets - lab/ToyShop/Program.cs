using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrize = double.Parse(Console.ReadLine());
            int countPuzzels = int.Parse(Console.ReadLine());
            int countDolls = int.Parse(Console.ReadLine());
            int countBear = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTrucks = int.Parse(Console.ReadLine());

            double result = countPuzzels * 2.60 + countDolls * 3 + countBear * 4.10 + countMinions * 8.20 + countTrucks * 2;

          //  Console.WriteLine(result);

            int countEverything = countPuzzels + countDolls + countBear + countMinions + countTrucks;
           // Console.WriteLine(countEverything);
            if (countEverything>= 50)
            {
                result = result - result * 0.25; 
            }

            result = result - result * 0.1;

            //Console.WriteLine(result); 
             

            if (result >= excursionPrize)
            {
                Console.WriteLine($"Yes! {result - excursionPrize:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursionPrize - result:F2} lv needed."); 
            }


                
         
        }
    }
}
