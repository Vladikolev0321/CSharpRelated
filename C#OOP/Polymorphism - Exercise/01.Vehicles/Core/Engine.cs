using P01.Vehicles.Models;
using P01.Vehicles.Models.Factorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace P01.Vehicles.Core
{
    public class Engine
    {
        private VehicleFactory vehicleFactory ;

        public Engine()
        {
            vehicleFactory = new VehicleFactory();
        }

        public void Run()
        {
            Vehicle car = ProduceVehicle();
            Vehicle truck = ProduceVehicle();
            Vehicle bus = ProduceVehicle();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                try
                {
                    ProcessCommand(car, truck,bus, cmdArgs);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }


            }

            //Console.WriteLine($"{car.FuelQuantity:F2}");
            //Console.WriteLine($"{truck.FuelQuantity:F2}");
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus);



        }

        private static void ProcessCommand(Vehicle car, Vehicle truck,Vehicle bus, string[] cmdArgs)
        {
            string action = cmdArgs[0];
            string type = cmdArgs[1];
            if (action == "Drive")
            {

                double kilometers = double.Parse(cmdArgs[2]);
                if (type == "Car")
                {
                    Console.WriteLine(car.Drive(kilometers));
                }
                else if (type == "Truck")
                {
                    Console.WriteLine(truck.Drive(kilometers));
                }
                else if(type == "Bus")
                {
                    Console.WriteLine(bus.Drive(kilometers));
                }
            }
            else if (action == "Refuel")
            {
                double liters = double.Parse(cmdArgs[2]);
                if (type == "Car")
                {
                    car.Refuel(liters);
                }
                else if (type == "Truck")
                {
                    truck.Refuel(liters);
                }
                else if (type == "Bus")
                {
                    bus.Refuel(liters);
                }
                
            }
            else if(action == "DriveEmpty")
            {
                double kilometers = double.Parse(cmdArgs[2]);
                Console.WriteLine(bus.DriveEmpty(kilometers));
            }
        }

        private Vehicle ProduceVehicle()
        {
            string[] vehicleArgs = Console.ReadLine()
                                        .Split()
                                        .ToArray();
            string type = vehicleArgs[0];
            double fuelQuantity = double.Parse(vehicleArgs[1]);
            double fuelCons = double.Parse(vehicleArgs[2]);
            double tankCapacity = double.Parse(vehicleArgs[3]);

            Vehicle vehicle = vehicleFactory
                .ProduceVehicle(type, fuelQuantity, fuelCons,tankCapacity);
            return vehicle;
        }



    }
}
