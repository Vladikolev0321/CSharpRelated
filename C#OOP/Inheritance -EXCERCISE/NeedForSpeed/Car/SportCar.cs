using System;
using System.Collections.Generic;
using System.Text;

namespace P04.NeedForSpeed.Car
{
    public class SportCar : Car
    {
        private const double defaultFuelConsumption = 10;

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
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
