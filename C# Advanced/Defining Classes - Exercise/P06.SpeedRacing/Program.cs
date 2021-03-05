using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Car> cars = new HashSet<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split();
                string model = carArgs[0];
                double fuelAmount = double.Parse(carArgs[1]);
                double fuelConsPerKm = double.Parse(carArgs[2]);

                Car car = new Car(model, fuelAmount, fuelConsPerKm);
                /////TO CHECK IF THERE IS A CAR WITH THE SAME MODEL
                cars.Add(car);

            }

            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] driveArgs = command
                    .Split();

                string carModel = driveArgs[1];
                int amountOfKm = int.Parse(driveArgs[2]);

                var searchedCar = cars.First(c => c.Model == carModel);

                searchedCar.Drive(amountOfKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
