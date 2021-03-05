using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Vehicle_Catalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public int HorsePower { get; set; }
    }
    class CatalogVehicle
    {
        public CatalogVehicle()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CatalogVehicle catalog = new CatalogVehicle();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }
                string[] info = input.Split("/");
                string brand = info[1];
                string model = info[2];
                int HorsePowerOrWeight = int.Parse(info[3]);
                
                if(info[0] == "Car")
                {
                    Car car = new Car();
                    
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = HorsePowerOrWeight;

                    catalog.Cars.Add(car);                   
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = HorsePowerOrWeight;

                    catalog.Trucks.Add(truck);
                }
            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
                {

                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {

                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
