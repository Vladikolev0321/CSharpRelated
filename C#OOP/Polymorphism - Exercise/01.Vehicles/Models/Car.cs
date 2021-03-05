using P01.Vehicles.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCREMENT = 0.9;

        public Car(double fuelquantity, double fuelconsumption, double tankCapacity)
            : base(fuelquantity, fuelconsumption, tankCapacity)
        {
        }

        public override double FuelConsumption
        {
            get
            {
                return base.FuelConsumption;
            }
            protected set
            {
                base.FuelConsumption = value + FUEL_CONSUMPTION_INCREMENT;
            }
        }

        
    }
}
