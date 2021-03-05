using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passingCars = int.Parse(Console.ReadLine());

            int totatalCarsPassed = 0;

            Queue<string> cars = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i < passingCars; i++)
                    {
                        if (cars.Any())
                        {
                            totatalCarsPassed++;
                        
                            string  currentCar = cars.Dequeue();
                            Console.WriteLine($"{currentCar} passed");
                        }
                    }
                }
                else
                {
                cars.Enqueue(command);
                }


            }

            Console.WriteLine($"{totatalCarsPassed} cars passed the crossroads.");
        }
    }
}
