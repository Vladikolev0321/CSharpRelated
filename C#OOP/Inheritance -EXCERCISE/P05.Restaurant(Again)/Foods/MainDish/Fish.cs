using System;
using System.Collections.Generic;
using System.Text;

namespace P05.Restaurant_Again_.Foods.MainDish
{
    public class Fish : MainDish
    {
        private const double FishGrams = 22;
        public Fish(string name, decimal price)
            : base(name, price, FishGrams)
        {
        }
    }
}
