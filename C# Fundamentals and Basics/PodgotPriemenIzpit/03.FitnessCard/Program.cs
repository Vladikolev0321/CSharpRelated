using System;

namespace _03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double neededSum = 0;

            switch(sport)
            {
                case "Gym":
                    if(gender == "m")
                    {
                        neededSum = 42;
                    }
                    else
                    {
                        neededSum = 35;
                    }
                    break;
                case "Boxing":
                    if (gender == "m")
                    {
                        neededSum = 41;
                    }
                    else
                    {
                        neededSum = 37;
                    }
                    break;
                case "Yoga":
                    if (gender == "m")
                    {
                        neededSum = 45;
                    }
                    else
                    {
                        neededSum = 42;
                    }
                    break;
                case "Zumba":
                    if (gender == "m")
                    {
                        neededSum = 34;
                    }
                    else
                    {
                        neededSum = 31;
                    }
                    break;
                case "Dances":
                    if (gender == "m")
                    {
                        neededSum = 51;
                    }
                    else
                    {
                        neededSum = 53;
                    }
                    break;
                case "Pilates":
                    if (gender == "m")
                    {
                        neededSum = 39;
                    }
                    else
                    {
                        neededSum = 37;
                    }
                    break;
            }

            if(age<=19)
            {
                neededSum = neededSum - neededSum * 0.2;
            }

            if(sum >= neededSum)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${neededSum - sum:F2} more.");
            }
        }
    }
}
