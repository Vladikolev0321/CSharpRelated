using P01.Vehicles.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace P01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_CONS_INCREMENT = 1.6;
        private const double REFUEL_EFIICIENCY_PERCENTSGE = 0.95;

        public Truck(double fuelquantity, double fuelconsumption, double tankCapacity)
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
                base.FuelConsumption = value + FUEL_CONS_INCREMENT;
            }

        }

        public override void Refuel(double liters)
        {
            double litersIn = liters * REFUEL_EFIICIENCY_PERCENTSGE;
            if(liters > 0)
            {
                if (this.FuelQuantity + litersIn > this.TankCapacity)
                {
                    string exc = string.Format(ExceptionMessage
                        .InvalidFuelTankExceptionMessage, liters);
                    throw new InvalidOperationException(exc);
                }
                this.FuelQuantity += litersIn;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessage.FuelIsNegativeOrZero);
            }
        }

    }
}
