using P04.PizzaCalories.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories
{
    public class Pizza
    {
        private string name;
       // private Dough dough;
        private int numberOfToppings;

        public Pizza(string name,Dough dough)
        {
            this.Name = name;
            this.Dough = dough;

            this.TotalCalories += this.Dough.DoughCalories();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public int NumberOfToppings
        {
            get
            {
                return this.numberOfToppings;
            }
            private set
            {
                if(numberOfToppings < 0 || numberOfToppings > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.numberOfToppings = value;
            }
        }
        public Dough Dough { get; set; }
        public double TotalCalories { get; private set; }

        public void AddTopping(Topping topping)
        {
            this.TotalCalories += topping.ToppingCalories();
            this.NumberOfToppings++;
        }

    }
}
