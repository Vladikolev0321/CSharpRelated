using System;

namespace Beehive_Defence
{
    class Program
    {
        static void Main(string[] args)
        {
            int beeCount = int.Parse(Console.ReadLine());
            int healthBear = int.Parse(Console.ReadLine());
            int attackBear = int.Parse(Console.ReadLine());

            while(true)
            {
                beeCount = beeCount - attackBear;
                if(beeCount<100)
                {   if(beeCount<0)
                    {
                        beeCount = 0;
                    }
                    Console.WriteLine($"The bear stole the honey! Bees left {beeCount}.");
                    break;
                }
                healthBear -= beeCount * 5; 
                if(healthBear<=0)
                {
                    Console.WriteLine($"Beehive won! Bees left {beeCount}.");
                    break;
                }
            }    

        }
    }
}
