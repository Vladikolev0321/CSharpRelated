using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeScene = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int collons = int.Parse(Console.ReadLine());

            double income = 0;
            
            switch (typeScene)
            {
                case "Premiere":
                    income = rows * collons * 12.00;
                    break;
                case "Normal":
                    income = rows * collons * 7.50;
                    break;
                case "Discount":
                    income = rows * collons * 5.00;
                    break;

            }
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
