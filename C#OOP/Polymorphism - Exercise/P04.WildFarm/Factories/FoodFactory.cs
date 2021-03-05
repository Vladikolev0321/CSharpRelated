using P04.WildFarm.Contracts;
using P04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Factories
{
    public class FoodFactory
    {
        public IFood ProduceFood(string type, int quantity)
        {
            IFood food = null;

            if(type == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if(type == "Fruit")
            {
                food = new Fruit(quantity);
            }
            else if(type == "Meat")
            {
                food = new Meat(quantity);
            }
            else if(type == "Seeds")
            {
                food = new Seeds(quantity);
            }

            return food;

        }
    }
}
