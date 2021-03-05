using System;
using System.Collections.Generic;
using System.Text;

namespace P06.FoodShortage.Contracts
{
    public interface IBuyer
    {
        void BuyFood();
        int Food { get; }
    }
}
