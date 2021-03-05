using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int durationOfGreenLight = int.Parse(Console.ReadLine());
            int durationOfFreeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            bool crashed = false;
            string crashedCar = string.Empty;
            int hitIndex = -1;
            int totalCarsPassed = 0;

            string command;
            while((command = Console.ReadLine()) != "END")
            {
                if (command == "green")
                {
                    int currentGreenLight = durationOfGreenLight;
                    while (cars.Any() && currentGreenLight > 0)
                    {
                        string currCar = cars.Peek();
                        int carLength = currCar.Length;

                        if (carLength <= currentGreenLight )
                        {
                            totalCarsPassed++;
                            currentGreenLight -= currCar.Length;
                            cars.Dequeue();
                        }
                        else
                        {
                            carLength -= currentGreenLight;
                            if (carLength <= durationOfFreeWindow)
                            {
                                totalCarsPassed++;
                                cars.Dequeue();
                            }
                            else
                            {
                                crashed = true;
                                crashedCar = currCar;
                                hitIndex = currentGreenLight
                                    + durationOfFreeWindow;
                            }
                                break;
                        }
                        
                    }
                    
                }
                else
                {
                    cars.Enqueue(command);
                }
                if (crashed)
                {
                    break;
                }
            }
            if (crashed)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{crashedCar} was hit at {crashedCar[hitIndex]}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
            }
        }
    }
}
