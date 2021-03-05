using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private readonly ICollection<Employee> data;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public Bakery(string name, int capacity)
        {
            this.data = new List<Employee>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public void Add(Employee employee)
        {
            if(this.data.Count < this.Capacity)
            {
                this.data.Add(employee);
            }
        }
        public bool Remove(string name)
        {
            return this.data.Remove(this.data.FirstOrDefault(e => e.Name == name));
        }
        public Employee GetOldestEmployee()
        {
            return this.data.OrderByDescending(e => e.Age).First();
        }
        public Employee GetEmployee(string name)
        {
            return this.data.FirstOrDefault(e => e.Name == name);
        }

        public int Count { get => this.data.Count; }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}:");
            foreach(var em in this.data)
            {
                sb.AppendLine(em.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
