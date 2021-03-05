using System;

namespace _02.Mountain_Rain
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double recordInMet = double.Parse(Console.ReadLine());
            double timeFor1m = double.Parse(Console.ReadLine());

            double secGeorge = recordInMet * timeFor1m;
            double timesSlow = Math.Floor(recordInMet / 50);
            secGeorge = secGeorge + timesSlow * 30;

            if(secGeorge < recordInSec)
            {
                Console.WriteLine($"Yes! The new record is {secGeorge:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {secGeorge-recordInSec:F2} seconds slower.");
            }
        }
    }
}
