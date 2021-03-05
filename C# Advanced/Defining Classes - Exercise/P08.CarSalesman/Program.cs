using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] engineArgs = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string model = engineArgs[0];
                int power = int.Parse(engineArgs[1]);
                Engine engine = null;
                if (engineArgs.Length == 4)
                {
                    int displacement = int.Parse(engineArgs[2]);
                    string efficiency = engineArgs[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }
                else if (engineArgs.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(engineArgs[2],out displacement))
                    {
                         displacement = int.Parse(engineArgs[2]);
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = engineArgs[2];
                        engine = new Engine(model, power, efficiency);
                    }

                }
                else if (engineArgs.Length == 2)
                {
                    engine = new Engine(model, power);
                }

                engines.Add(engine);
            }
            List<Car> cars = new List<Car>();
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];
                Engine engine = engines.First(e => e.Model == carArgs[1]);

                Car car = null;
                if (carArgs.Length == 4)
                {
                    int weight = int.Parse(carArgs[2]);
                    string color = carArgs[3];

                    car = new Car(model, engine, weight, color);
                }
                else if (carArgs.Length == 3)
                {
                    int weight;
                    if (!int.TryParse(carArgs[2], out weight))
                    {
                        string color = carArgs[2];
                        car = new Car(model, engine, color);
                    }
                    else
                    {
                         weight = int.Parse(carArgs[2]);
                        car = new Car(model, engine, weight);
                    }
                }
                else if (carArgs.Length == 2)
                {
                    car = new Car(model, engine);
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
