using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Models.Animals.Mammals.Felines
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string livingRegion,string breed)
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }
        public string Breed { get; private set; }
        public override string ToString()
        {
            return base.ToString()
                + $" {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
