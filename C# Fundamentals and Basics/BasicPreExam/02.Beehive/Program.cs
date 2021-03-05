using System;

namespace _02.Beehive
{
    class Program
    {
        static void Main(string[] args)
        {
            int intelligence = int.Parse(Console.ReadLine());
            int strenght = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if(intelligence >= 80 && strenght >= 80 && gender == "female")
            {
                Console.WriteLine("Queen Bee");
            }
            else if (intelligence >= 80 ) 
            {
                Console.WriteLine("Repairing Bee");
            }
            else if (intelligence >= 60)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else if ( strenght >= 80 && gender == "male")
            {
                Console.WriteLine("Drone Bee");
            }
            else if (strenght >= 60)
            {
                Console.WriteLine("Guard Bee");
            }
            else
            {
                Console.WriteLine("Worker Bee");

            }

        }
    }
}
