using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int countWonBattles = 0;
            bool notEnoughEnergy = false;

            string command;
            while((command = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(command);             
                if(initialEnergy >= distance)
                {
                    initialEnergy -= distance;
                    countWonBattles++;
                }
                else
                {
                    notEnoughEnergy = true;
                    break;
                }

                if (countWonBattles % 3 == 0)
                {
                    initialEnergy += countWonBattles;
                }
            }


            if (notEnoughEnergy)
            {
                Console.WriteLine($"Not enough energy! Game ends with {countWonBattles} won battles and {initialEnergy} energy");
            }
            else
            {
                Console.WriteLine($"Won battles: {countWonBattles}. Energy left: {initialEnergy}");
            }


        }
    }
}
