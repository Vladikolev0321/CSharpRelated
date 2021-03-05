using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private  List<Rabbit> data;
        public Cage(string name , int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            data = new List<Rabbit>();
        }
        public int Count
            => data.Count;
        public string Name { get; private set; }
        public int Capacity { get; private set; }

        public void Add(Rabbit rabbit)
        {
            if(this.Count < this.Capacity)
            {
                data.Add(rabbit);
            }
        }
        public bool RemoveRabbit(string name)
        {
            return data.Remove(data.FirstOrDefault(r => r.Name == name));
        }
        public void RemoveSpecies(string species)
        {
            data.RemoveAll(r => r.Species == species);
        }
        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbitToSell = data.FirstOrDefault(r => r.Name == name);
            if(rabbitToSell != null)
            {
                rabbitToSell.Available = false;
            }
            return rabbitToSell;
        }


        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var rabbitsToSell = data.Where(r => r.Species == species).ToArray();
            foreach (var rabbit in rabbitsToSell)
            {
                rabbit.Available = false;
            }

            return rabbitsToSell;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Rabbits available at {this.Name}:");
            foreach (Rabbit rabbit in data.Where(r => r.Available == true))
            {
                sb.AppendLine(rabbit.ToString());
            }
            return sb.ToString().TrimEnd();

        }
    }
}
