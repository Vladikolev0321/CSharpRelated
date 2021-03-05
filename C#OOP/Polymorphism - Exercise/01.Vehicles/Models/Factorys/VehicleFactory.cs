using P01.Vehicles.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Vehicles.Models.Factorys
{
    public class VehicleFactory
    {
        public Vehicle ProduceVehicle(string type , double fuelQty , double fuelCons , double tankCapacity)
        {
            Vehicle vehicle = null;
            if(type == "Car")
            {
                vehicle = new Car(fuelQty,fuelCons,tankCapacity);
            }
            else if(type == "Truck")
            {
                vehicle = new Truck(fuelQty, fuelCons,tankCapacity);
            }
            else if(type == "Bus")
            {
                vehicle = new Bus(fuelQty, fuelCons, tankCapacity);
            }

            if(vehicle == null)
            {
                throw new ArgumentException(ExceptionMessage
                    .InvalidTypeVehicleExceptionMessage);
            }

            return vehicle;
        }
    }
}
