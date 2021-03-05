using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            double priceDolls = double.Parse(Console.ReadLine());

            int countDolls = 0;
            double moneyEarned = 0;
            int countStealedMoney = 0;
            int savedMoney = 0;

            for(int i=1;i<=age;i++)
            {
                if(i % 2 == 0)
                {
                    savedMoney += 10;
                    moneyEarned += savedMoney;
                    countStealedMoney++;
                }
                else
                {
                    countDolls++;
                }
            }
            moneyEarned = moneyEarned + countDolls * priceDolls -countStealedMoney*1;
            if(moneyEarned >= priceLaundry)
            {
                Console.WriteLine($"Yes! {moneyEarned - priceLaundry:F2}");
            }
            else
            {
                Console.WriteLine($"No! {priceLaundry - moneyEarned:F2}");
            }

        }
    }
}
