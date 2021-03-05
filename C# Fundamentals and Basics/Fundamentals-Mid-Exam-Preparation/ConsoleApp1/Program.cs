using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsADay = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            
            int otherFactoryBiscuitsfor30Days = int.Parse(Console.ReadLine());

            int sumBiscuits = 0;
            for (int i = 1; i <= 30; i++)
            {
                if(i % 3 == 0)
                {
                   // sumBiscuits += countWorkers * (int)Math.Floor(biscuitsADay * 0.75);
                    sumBiscuits +=  (int)Math.Floor(countWorkers *biscuitsADay * 0.75);

                    //sumBiscuits += Math.Floor(countWorkers*biscuitsADay * 0.75);

                }
                else
                {
                    sumBiscuits += countWorkers * biscuitsADay;
                }
            }
            Console.WriteLine($"You have produced {sumBiscuits} biscuits for the past month.");

            if(sumBiscuits > otherFactoryBiscuitsfor30Days)
            {
                int diff = sumBiscuits - otherFactoryBiscuitsfor30Days;
                Console.WriteLine($"You produce {(double)diff / otherFactoryBiscuitsfor30Days * 100:F2} percent more biscuits.");
            }
            else
            {
                int diff = otherFactoryBiscuitsfor30Days - sumBiscuits;
                Console.WriteLine($"You produce {(double)diff / otherFactoryBiscuitsfor30Days * 100:F2} percent less biscuits.");
            }
        }
    }
}
