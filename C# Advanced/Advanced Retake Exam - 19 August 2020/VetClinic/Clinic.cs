using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private readonly ICollection<Pet> data;

        public int Capacity { get; set; }

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();
        }
        public void Add(Pet pet)
        {
            if(data.Count != Capacity)
            {
                this.data.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            return data.Remove(data.FirstOrDefault(p => p.Name == name));
        }
        public Pet GetPet(string name, string owner)
        {
            return data.FirstOrDefault(p => p.Name == name && p.Owner == owner);
        }
        public Pet GetOldestPet()
        {
            return data.OrderByDescending(p => p.Age).First();
        }
        public int Count { get => data.Count; }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");

            foreach(var pet in data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
