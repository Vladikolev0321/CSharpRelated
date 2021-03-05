using System;
using System.Collections.Generic;
using System.Text;

namespace P08.CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "n/a";
        }
        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }
        public string Model { get; private set; }
        public Engine Engine { get; private set; }
        public int Weight { get; private set; }
        public string Color { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"{this.Model}:")
                .AppendLine(Engine.ToString());

            if (this.Weight == 0)
            {
                sb.AppendLine("  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }

            sb.AppendLine($"  Color: {this.Color}");

            return sb.ToString().TrimEnd();
        }
    }
}
