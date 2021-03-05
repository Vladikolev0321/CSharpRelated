using System;

namespace ChristmasTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            
            double moneyRaisedThisDay = 0;
            double allMoney = 0;
          
            int countWinDay = 0;

            
            int countLostDay = 0;
            for (int i = 0; i < days; i++)
            {  
                int countWins = 0;
                int countLosses = 0;
                moneyRaisedThisDay = 0;

                string command = Console.ReadLine();
                while (command != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        moneyRaisedThisDay += 20;
                        countWins++;
                    }
                    else
                    {
                        countLosses++;
                    }

                    command = Console.ReadLine();
                }
                if (countWins > countLosses)
                {
                    moneyRaisedThisDay += moneyRaisedThisDay * 0.1;
                    allMoney += moneyRaisedThisDay;
                    countWinDay++;
                }
                else
                {
                    allMoney += moneyRaisedThisDay;
                    countLostDay++;
                }
            }
            if(countWinDay > countLostDay)
            {
                allMoney += allMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {allMoney:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {allMoney:F2}");
            }

        }
    }
}
