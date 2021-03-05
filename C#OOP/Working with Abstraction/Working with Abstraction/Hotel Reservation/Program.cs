using System;

namespace Hotel_Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new PriceCalculator();

            calculator.Calculate(10.5, Season.Spring);
        }
    }
}
