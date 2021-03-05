using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double recordMet = double.Parse(Console.ReadLine());
            double secForMet = double.Parse(Console.ReadLine());

            double secNeededForThoseMet = recordMet * secForMet;
           //int times15meters = recordMet / 15;
            double secPlusFor15Meters = Math.Floor(recordMet / 15) * 12.5;
           
          //  Console.WriteLine(recordMet / 15);
           // Console.WriteLine(secPlusFor15Meters);

            double totalSec = secNeededForThoseMet + secPlusFor15Meters; 

            if(totalSec < recordSec)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSec:F2} seconds.");

            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalSec - recordSec:F2} seconds slower.");
            }                
        }
    }
}
