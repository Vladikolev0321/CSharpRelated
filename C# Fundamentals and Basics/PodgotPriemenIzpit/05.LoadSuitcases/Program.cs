using System;

namespace _05.LoadSuitcases
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int countluggage = 0;
            bool noSpace = false;

            while(command != "End")
            {
               double capSuitcase = double.Parse(command);
               if((countluggage+1)%3==0)
                {
                    capSuitcase = capSuitcase + capSuitcase * 0.1;
                }
               if(capacity<capSuitcase)
                {
                    noSpace = true;
                    break;
                }
               capacity = capacity - capSuitcase;
               countluggage++;
               command = Console.ReadLine();
            }

            if(command=="End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            if(noSpace == true)
            {
                Console.WriteLine("No more space!");
            }
            Console.WriteLine($"Statistic: {countluggage} suitcases loaded.");
           // Console.WriteLine(capacity);

        }
    }
}
