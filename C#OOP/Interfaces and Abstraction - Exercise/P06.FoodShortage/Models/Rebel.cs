using P06.FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P06.FoodShortage.Models
{
    public class Rebel:IBuyer
    {
       // private string name;
        private int age;
        private string group;
        private int food = 0;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.age = age;
            this.group = group;
        }
        public string Name { get; }

        public int Food
        {
            get
            {
                return this.food;
            }
            private set
            {
                this.food = value;
            }
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
