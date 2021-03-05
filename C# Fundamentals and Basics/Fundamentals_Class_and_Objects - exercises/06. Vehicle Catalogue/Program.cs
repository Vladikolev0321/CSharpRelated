using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
   
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }
                string[] command = input.Split();
                string type = command[0];
                string model = command[1];
                string color = command[2];
                int horsePower = int.Parse(command[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                catalogue.Add(vehicle);

            }

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Close the Catalogue")
                {
                    break;
                }
                Vehicle vehicleWithThatModel = catalogue.Find(v => v.Model == input);

                Console.WriteLine(vehicleWithThatModel.ToString());
                
            }
            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double sumCarsHorse = 0;
            double sumTrucksHorse = 0;

            foreach (Vehicle car in onlyCars)
            {
                sumCarsHorse += car.HorsePower;
            }
            foreach (Vehicle truck in onlyTrucks)
            {
                sumTrucksHorse += truck.HorsePower;
            }

            double averageCars = sumCarsHorse / onlyCars.Count;
            double averageTrucks = sumTrucksHorse / onlyTrucks.Count;

          //  Console.WriteLine($"Cars have average horsepower of: {Math.Round(averageCars,2):F2}.");
          //  Console.WriteLine($"Trucks have average horsepower of: {Math.Round(averageTrucks, 2):F2}.");
            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {Math.Round(averageCars, 2):F2}.");


            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {Math.Round(averageTrucks, 2):F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }
    }
    class Vehicle
    {
        public Vehicle(string type,string model,string color,int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            if (this.Type == "car")
            {
                return $"Type: Car\n" +
                $"Model: {this.Model}\n" +
                $"Color: {this.Color}\n" +
                $"Horsepower: {this.HorsePower}\n".Trim();
            }
            else
            {
                return $"Type: Truck\n" +
                $"Model: {this.Model}\n" +
                $"Color: {this.Color}\n" +
                $"Horsepower: {this.HorsePower}\n".Trim();
            }

        }
    }
}
