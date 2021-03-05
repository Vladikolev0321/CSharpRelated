using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double result = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":                  
                case "Wednesday":
                case "Thursday":                   
                case "Friday":
                 
                    switch(fruit)
                    {
                        case "banana":
                            result = 2.50 * count;
                            break;
                        case "apple":
                            result = 1.20 * count;
                            break;
                        case "orange":
                            result = 0.85 * count;
                            break;
                        case "grapefruit":
                            result = 1.45 * count;
                            break;
                        case "kiwi":
                            result = 2.70 * count;
                            break;
                        case "pineapple":
                            result = 5.50 * count;
                            break;
                        case "grapes":
                            result = 3.85 * count;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            result = 2.70 * count;
                            break;
                        case "apple":
                            result = 1.25 * count;
                            break;
                        case "orange":
                            result = 0.90 * count;
                            break;
                        case "grapefruit":
                            result = 1.60 * count;
                            break;
                        case "kiwi":
                            result = 3.00 * count;
                            break;
                        case "pineapple":
                            result = 5.60 * count;
                            break;
                        case "grapes":
                            result = 4.20 * count;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
            if (result != 0)
            {
                Console.WriteLine($"{result:f2}");
            }
            
           

        }
    }
}
