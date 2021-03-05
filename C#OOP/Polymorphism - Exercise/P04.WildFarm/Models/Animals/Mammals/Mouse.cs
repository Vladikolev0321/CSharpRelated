using P04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Models.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double WEIGHT_MULT = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override double WeightMultiplier => WEIGHT_MULT;

        public override ICollection<Type> PrefferedFoods =>
            new List<Type>() { typeof(Vegetable), typeof(Fruit) };

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
        public override string ToString()
        {
            return base.ToString() + $" {this.Weight}, { this.LivingRegion}, { this.FoodEaten}]";
        }
    }
}
