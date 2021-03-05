using P01.Vehicles.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Vehicles.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelquantity, double fuelconsumption, double tankCapacity)
            : base(fuelquantity, fuelconsumption, tankCapacity)
        {
        }

        public override string Drive(double kilometers)
        {
            double fuelNeeded = kilometers * (this.FuelConsumption + 1.4);

            if (this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(string
                    .Format(ExceptionMessage.NotEnoughFuelExceptionMessage
                    , this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;
            return $"{this.GetType().Name} travelled {kilometers} km";
        }
        

    }
}
