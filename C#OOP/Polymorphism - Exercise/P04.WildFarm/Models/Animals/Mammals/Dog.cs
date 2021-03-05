using P04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        private const double WEIGHT_MULT = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => WEIGHT_MULT;

        public override ICollection<Type> PrefferedFoods
            => new List<Type>() { typeof(Meat) };

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
        public override string ToString()
        {
            return base.ToString() + $" {this.Weight}, { this.LivingRegion}, { this.FoodEaten}]";
        }
    }
}
