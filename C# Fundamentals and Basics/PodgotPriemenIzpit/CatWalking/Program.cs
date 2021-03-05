using System;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesADay = int.Parse(Console.ReadLine());
            int countRazhodki = int.Parse(Console.ReadLine());
            int CaloriesIntake = int.Parse(Console.ReadLine());

            int burnedCalories = countRazhodki * minutesADay * 5;
            if (burnedCalories >= (0.5 * CaloriesIntake))
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }

        }
    }
}
