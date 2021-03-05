using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories.Ingredients
{
    public class Topping
    {
        private string toppingType;
        private double weight;
        private const double baseCaloriesPerGram = 2;

        public Topping(string toppingType , double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public string ToppingType
        {
            get
            {
                return this.toppingType;
            }
            private set
            {
                if(value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public double ToppingCalories()
        {
            double toppingModifier = FindModifier();

            return baseCaloriesPerGram * this.Weight * toppingModifier;
        }

        private double FindModifier()
        {
            double toppingTypeModifier = 0;
            switch (this.ToppingType.ToLower())
            {
                case "meat":
                    toppingTypeModifier = 1.2;
                    break;
                case "veggies":
                    toppingTypeModifier = 0.8;
                    break;
                case "cheese":
                    toppingTypeModifier = 1.1;
                    break;
                case "sauce":
                    toppingTypeModifier = 0.9;
                    break;
            }
            return toppingTypeModifier;
        }
    }
}
