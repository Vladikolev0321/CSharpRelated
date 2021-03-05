using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalMoney = 0;
            while(command != "Start")
            {
                double ins = double.Parse(command);
                if(ins == 0.1 || ins == 0.2 || ins == 0.5 || ins == 1 || ins == 2)
                {
                    totalMoney += ins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {ins}");
                }
                command = Console.ReadLine();
            }

            string command2 = Console.ReadLine();
            while(command2 != "End")
            {
                string product = command2;
                switch (product)
                {
                    case "Nuts":
                        if(totalMoney >= 2)
                        {
                            totalMoney -= 2;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (totalMoney >= 0.7)
                        {
                            totalMoney -= 0.7;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (totalMoney >= 1.5)
                        {
                            totalMoney -= 1.5;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (totalMoney >= 0.8)
                        {
                            totalMoney -= 0.8;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (totalMoney >= 1)
                        {
                            totalMoney -= 1;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                       
                } command2 = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
