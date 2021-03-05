using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = 0;
            double totalTaxes = 0;
            string input;
            while((input = Console.ReadLine()) != "special" && input != "regular")
            {
                double currPrice = double.Parse(input);
                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                     totalTaxes += currPrice * 0.2;
                    //currPrice += currPrice * 0.2;

                     totalPrice += currPrice;
                }
            }
            double totalPriceWithDisc = totalPrice + totalTaxes;
            if(input == "special")
            {
                totalPriceWithDisc -= (totalPrice + totalTaxes) * 0.1;
            }
            
            
            if(totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!\n" +
                    $"Price without taxes: {totalPrice:F2}$\n" +
                    $"Taxes: {totalTaxes:F2}$\n" +
                    $"-----------\n" +
                    $"Total price: {totalPriceWithDisc:F2}$");
            }
        }
    }
}
