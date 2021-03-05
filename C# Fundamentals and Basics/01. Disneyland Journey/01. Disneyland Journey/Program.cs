using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double collectedMoney = 0;
            for (int i = 0; i < months; i++)
            {
                if((i+1) != 1 && (i + 1) % 2 != 0)
                {
                    collectedMoney -= collectedMoney * 0.16;
                }
                if((i+1) % 4 == 0)
                {
                    collectedMoney += collectedMoney * 0.25;
                }
                collectedMoney += 0.25 * moneyNeeded;
            }

            if(collectedMoney >= moneyNeeded)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {collectedMoney-moneyNeeded:F2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {moneyNeeded - collectedMoney:F2}lv. more.");
            }
        }
    }
}
