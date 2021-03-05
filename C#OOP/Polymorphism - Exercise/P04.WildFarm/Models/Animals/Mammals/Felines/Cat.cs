using P04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Models.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        private const double WEIGHT_MULT = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier
            => WEIGHT_MULT;

        public override ICollection<Type> PrefferedFoods
            => new List<Type>() { typeof(Vegetable), typeof(Meat)};

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
