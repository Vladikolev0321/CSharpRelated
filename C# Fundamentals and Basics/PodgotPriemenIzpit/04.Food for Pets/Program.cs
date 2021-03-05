using System;

namespace _04.Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            double allFood = double.Parse(Console.ReadLine());

         //   double eatenFoodADay = 0;
            double eatenByDog = 0;
            double eatenByCat = 0;
            double sumDog = 0;
           double sumCat = 0;
            double sumEaten = 0;
            double biscuits = 0;
            for(int i=1;i<=countDays;i++)
            {
                eatenByDog = double.Parse(Console.ReadLine());
                sumDog += eatenByDog;
                eatenByCat = double.Parse(Console.ReadLine());
                sumCat += eatenByCat;
               
                //eatenFoodADay = eatenByDog + eatenByCat;
                sumEaten += eatenByCat + eatenByDog;
                if(i%3==0)
                {
                    biscuits += (eatenByDog + eatenByCat) * 0.1;
                }

            }
           
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{sumEaten*100 / allFood:F2}% of the food has been eaten.");
            Console.WriteLine($"{sumDog*100/sumEaten:F2}% eaten from the dog.");
            Console.WriteLine($"{sumCat*100/sumEaten:F2}% eaten from the cat.");

        }
    }
}
