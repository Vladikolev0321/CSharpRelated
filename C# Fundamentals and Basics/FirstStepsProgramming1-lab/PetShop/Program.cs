using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDogs = int.Parse(Console.ReadLine());
            int countOther = int.Parse(Console.ReadLine());

            double neededMoney = countDogs * 2.50 + countOther * 4;
            Console.WriteLine($"{neededMoney} lv.");
        }
    }
}
