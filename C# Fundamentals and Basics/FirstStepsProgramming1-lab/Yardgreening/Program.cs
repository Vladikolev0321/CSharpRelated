using System;

namespace Yardgreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvMetri = double.Parse(Console.ReadLine());
            double priceWithoutdiscount = kvMetri * 7.61;
            double discount = priceWithoutdiscount * 0.18;
            double res = priceWithoutdiscount - discount;

            Console.WriteLine($"The final price is: {res} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
            
        }
    }
}
