using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;

            this.data = new List<Car>();
        }
        public string Type { get; private set; }

        public int Capacity { get; private set; }

        public int Count => this.data.Count;

        public void Add(Car car)
        {
            if (this.Count != this.Capacity)
            {
                this.data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            return this.data.Remove(this.data.FirstOrDefault
                (c => c.Manufacturer == manufacturer && c.Model == model));
        }
        public Car GetLatestCar()
        {
            return this.data.FirstOrDefault(c => c.Year == data.Max(c => c.Year));
        }
        public Car GetCar(string manufacturer, string model)
        {
            return this.data.FirstOrDefault
                (c => c.Manufacturer == manufacturer && c.Model == model);
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var car in data)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }


    }
}
