using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Contracts
{
    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }

        void Feed(IFood food);
        void ProduceSound();
    }
}
