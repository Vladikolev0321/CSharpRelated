using System;
using System.Collections.Generic;
using System.Text;

namespace P08.CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "n/a";
        }
        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            //this.Model = model;
            //this.Power = power;
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power, displacement)
        {
            //this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        public string Model { get; private set; }
        public int Power { get; private set; }
        public int Displacement { get; private set; }
        public string Efficiency { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine($"  {this.Model}:")
                .AppendLine($"    Power: {this.Power}");

            if (this.Displacement == 0)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.Displacement}");
            }

            sb.AppendLine($"    Efficiency: {this.Efficiency}");

            return sb.ToString().TrimEnd();
        }
    }
}
