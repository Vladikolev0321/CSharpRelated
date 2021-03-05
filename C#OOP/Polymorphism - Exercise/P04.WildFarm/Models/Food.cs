using P04.WildFarm.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Models
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; }
    }
}
