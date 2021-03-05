using System;
using System.Collections.Generic;
using System.Text;

namespace P06.SpeedRacing
{
    public class Car
    {
        public Car(string model,double fuelAmount,double fuelCons)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelCons;
        }
        public string Model { get; private set; }
        public double FuelAmount { get; private set; }

        public double FuelConsumptionPerKilometer { get; private set; }
        public double TravelledDistance { get; private set; }

        public void Drive(int kilometers)
        {
            double fuelNeeded = kilometers * this.FuelConsumptionPerKilometer;
            if(this.FuelAmount >= fuelNeeded)
            {
                this.FuelAmount -= fuelNeeded;
                this.TravelledDistance += kilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
