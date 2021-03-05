using P04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        private const double weight_multiplier = 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => weight_multiplier;

        public override ICollection<Type> PrefferedFoods
            => new List<Type>() { typeof(Vegetable), typeof(Fruit), typeof(Meat), typeof(Seeds) };

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
