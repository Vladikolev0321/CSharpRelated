using P01.Vehicles.Common;
using P01.Vehicles.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Vehicles.Models
{
    public  abstract class Vehicle : IDriveable, IRefueable
    {
        private double fuelquantity;
        private double tankCapacity;
        public Vehicle(double fuelquantity,double fuelconsumption,double tankCapacity)
        {
            this.FuelQuantity = fuelquantity > tankCapacity ? 0 : fuelquantity;
            this.FuelConsumption = fuelconsumption;
            this.TankCapacity = tankCapacity;
        }


        public double FuelQuantity 
        {
            get
            {
                return this.fuelquantity;
            }
            protected set 
            {                    
               //if(value < 0)
               //{
               //    throw new InvalidOperationException(ExceptionMessage.FuelIsNegativeOrZero);
               //}
                    this.fuelquantity = value;               
                
            } 
        }
        public virtual double FuelConsumption { get; protected set; }
        public double TankCapacity {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                this.tankCapacity = value;
            }
        }


        public virtual string Drive(double kilometers)
        {
            double fuelNeeded = kilometers * this.FuelConsumption;

            if(this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(string
                    .Format(ExceptionMessage.NotEnoughFuelExceptionMessage
                    ,this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {kilometers} km";
            
        }

        public virtual void Refuel(double liters)
        {
            //if()
            if(liters > 0)
            {             
                if(this.FuelQuantity + liters > this.TankCapacity)
                {
                    string exc = string.Format(ExceptionMessage
                        .InvalidFuelTankExceptionMessage, liters);
                    throw new InvalidOperationException(exc);
                }
                this.FuelQuantity += liters;
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessage.FuelIsNegativeOrZero);
            }

        }
        public string DriveEmpty(double kilometers)
        {
            return this.Drive(kilometers);
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
