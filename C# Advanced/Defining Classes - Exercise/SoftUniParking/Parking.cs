using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private readonly ICollection<Car> cars;
        private int capacity;
        
        public Parking(int capacity)
        {
            this.capacity = capacity;

            this.cars = new List<Car>();
        }

        public IReadOnlyCollection<Car> Cars
            => (IReadOnlyCollection<Car>)this.cars;

        public int Count
            => this.Cars.Count;

        public string AddCar(Car car)
        {
            if(this.Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
                //return false;
            }
            else if(this.capacity == this.Count)
            {
                return "Parking is full!";
            }
            else
            {
                this.cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string registrNum)
        {
            if(!this.Cars.Any(c => c.RegistrationNumber == registrNum))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                var carToRemove = this.Cars.First(c => c.RegistrationNumber == registrNum);
                this.cars.Remove(carToRemove);

                return $"Successfully removed {registrNum}";
            }
        }
        public Car GetCar(string registrNum)
        {
            Car carNeeded = null;
            if(this.Cars.Any(c => c.RegistrationNumber == registrNum))
            {
                 carNeeded = this.Cars.FirstOrDefault(c => c.RegistrationNumber == registrNum);
                
            }
            return carNeeded;

        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var rNum in RegistrationNumbers)
            {
                this.RemoveCar(rNum);
            }
        }

    }
}
