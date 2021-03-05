using System;
using System.Collections.Generic;
using System.Text;

namespace P04.NeedForSpeed.Motorcycles
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double defaultFuelConsumption = 8;

        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => defaultFuelConsumption;
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
