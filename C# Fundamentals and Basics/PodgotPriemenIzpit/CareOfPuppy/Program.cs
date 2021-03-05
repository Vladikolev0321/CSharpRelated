using System;

namespace CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int purchasedFoodInKg = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int sumFoodInGrams = 0;
            while(command!="Adopted")
            {
                int foodInGram = int.Parse(command);
                sumFoodInGrams += foodInGram;
                command = Console.ReadLine();
            }
            if(purchasedFoodInKg*1000>=sumFoodInGrams)
            {
                Console.WriteLine($"Food is enough! Leftovers: {purchasedFoodInKg*1000-sumFoodInGrams} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {sumFoodInGrams - purchasedFoodInKg*1000} grams more.");
            }
        }
    }
}
