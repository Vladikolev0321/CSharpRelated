using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double totalMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spendingCounter = 0;
            while(totalMoney < moneyNeeded && spendingCounter < 5)
            {
                string operation = Console.ReadLine();
                double num = double.Parse(Console.ReadLine());
                days++;

                if(operation == "spend")
                {
                    
                    totalMoney = totalMoney - num;
                    spendingCounter++;
                    if(totalMoney < 0)
                    {
                        totalMoney = 0;
                    }
                }
                else if(operation == "save")
                {
                    totalMoney = totalMoney + num;
                    spendingCounter = 0;
                }

            }
            if(spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
