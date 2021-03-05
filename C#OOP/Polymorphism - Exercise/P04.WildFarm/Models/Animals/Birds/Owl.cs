using P04.WildFarm.Contracts;
using P04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        private const double WEIGHT_MULTIPLIER = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier
            => WEIGHT_MULTIPLIER;


        public override ICollection<Type> PrefferedFoods
            => new List<Type>() { typeof(Meat)};

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
