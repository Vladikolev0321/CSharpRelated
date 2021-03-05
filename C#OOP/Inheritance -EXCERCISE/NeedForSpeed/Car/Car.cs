using System;
using System.Collections.Generic;
using System.Text;

namespace P04.NeedForSpeed.Car
{
    public class Car : Vehicle
    {
        private const double defaultFuelConsumption = 3;

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption
        {
            get
            {
                return defaultFuelConsumption;
            }
        }

        //{
        //    get
        //    {
        //        return this.FuelConsumption;
        //    }
        //    set
        //    {
        //        this.FuelConsumption = defaultFuelConsumption;
        //    }
        //}

        public override void Drive(double kilometers)
        {
            double fuelAfterDrive = this.Fuel - kilometers * this.FuelConsumption;
            if (fuelAfterDrive >= 0)
            {
                this.Fuel -= kilometers * this.FuelConsumption;
            }

        }
    }
}
