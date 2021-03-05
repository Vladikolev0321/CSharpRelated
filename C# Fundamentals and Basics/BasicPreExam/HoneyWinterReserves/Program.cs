using System;

namespace HoneyWinterReserves
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyNeeded = double.Parse(Console.ReadLine());
            double sumHoney = 0;

            string command = Console.ReadLine();
            while(command != "Winter has come")
            {
                string nameBee = command;
               
                for (int i = 0; i < 6; i++)
                {
                    double honeyThisMonth = double.Parse(Console.ReadLine());
                    sumHoney += honeyThisMonth;
                }
                if(sumHoney < 0)
                {
                    Console.WriteLine($"{nameBee} was banished for gluttony");
                }
                //else if(sumHoney>=honeyNeeded)
                //{
                //    Console.WriteLine($"Well done! Honey surplus {sumHoney - honeyNeeded:F2}.");
                //}
                //else
                //{
                //    Console.WriteLine($"Hard Winter! Honey needed {honeyNeeded - sumHoney:F2}.");
                //}
                if (sumHoney >= honeyNeeded)
                  {
                    Console.WriteLine($"Well done! Honey surplus {sumHoney - honeyNeeded:F2}.");
                    break;
                 }
                command = Console.ReadLine();
            }


            if (sumHoney < honeyNeeded)
            {
                Console.WriteLine($"Hard Winter! Honey needed {honeyNeeded - sumHoney:F2}.");
            }
        }
    }
}
