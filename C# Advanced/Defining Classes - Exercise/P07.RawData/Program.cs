using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split();
                string model = carArgs[0];
                Engine engine = new Engine(int.Parse(carArgs[1]), int.Parse(carArgs[2]));
                Cargo cargo = new Cargo(int.Parse(carArgs[3]), carArgs[4]);
                Tire tire1 = new Tire(double.Parse(carArgs[5]), int.Parse(carArgs[6]));
                Tire tire2 = new Tire(double.Parse(carArgs[7]), int.Parse(carArgs[8]));
                Tire tire3 = new Tire(double.Parse(carArgs[9]), int.Parse(carArgs[10]));
                Tire tire4 = new Tire(double.Parse(carArgs[11]), int.Parse(carArgs[12]));
                List<Tire> tires = new List<Tire>() { tire1, tire2, tire3, tire4 };

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string typeCars = Console.ReadLine();
            if(typeCars == "fragile")
            {
                var sortedCars = cars
                    .Where(c => c.Cargo.Type == "fragile")
                    .Where(c => c.Tires.Any(t => t.Pressure < 1))
                    .ToList();
                Console.WriteLine(string.Join(Environment.NewLine, sortedCars.Select(c => c.Model)));
            }
            else
            {
                var sortedCars = cars
                    .Where(c => c.Cargo.Type == "flamable")
                    .Where(c => c.Engine.Power > 250)
                    .ToList();
                Console.WriteLine(string.Join(Environment.NewLine, sortedCars.Select(c => c.Model)));

            }

        }
    }
}
