using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var passingCars = int.Parse(Console.ReadLine());

            var cars = new Queue<string>();

                int totalCarsPassed = 0;
            while(true)


            {
                var command = Console.ReadLine();
                if (command == "green")
                {
                    for (int i = 0; i < passingCars; i++)
                    {
                        if (cars.Any())
                        {
                            totalCarsPassed++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                        }
                    }
                }
                else if (command == "end")
                {
                    break;
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"{totalCarsPassed} cars passed.");
        }
    }
}
