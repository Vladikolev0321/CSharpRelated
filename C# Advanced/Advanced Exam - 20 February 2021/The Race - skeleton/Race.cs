using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private readonly ICollection<Racer> data;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public Race(string name, int capacity)
        {
            this.data = new List<Racer>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public void Add(Racer Racer)
        {
            if(Capacity > this.data.Count)
            {
                this.data.Add(Racer);
            }
        }
        public bool Remove(string name)
        {
            return this.data.Remove(data.FirstOrDefault(r => r.Name == name));
        }
        public Racer GetOldestRacer()
        {
            return this.data.OrderByDescending(r => r.Age).FirstOrDefault();//
        }
        public Racer GetRacer(string name)
        {
            return data.FirstOrDefault(r => r.Name == name);
        }
        public Racer GetFastestRacer()
        {
            return this.data.OrderByDescending(r => r.Car.Speed).FirstOrDefault();
        }
        public int Count { get => this.data.Count; }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach(var racer in this.data)
            {
                sb.AppendLine(racer.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
