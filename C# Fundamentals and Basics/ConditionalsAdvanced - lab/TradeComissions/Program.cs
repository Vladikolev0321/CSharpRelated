using System;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double saled = double.Parse(Console.ReadLine());
            double commision = 0;
            switch(town)
            {
                case "Sofia":
                    if(saled >= 0 && saled <= 500)
                    {
                        commision = saled * 0.05;
                    }
                    else if (saled > 500 && saled <= 1000)
                    {
                        commision = saled * 0.07;
                    }
                    else if (saled > 1000 && saled <= 10000)
                    {
                        commision = saled * 0.08;
                    }
                    else if (saled > 10000)
                    {
                        commision = saled * 0.12;
                    }
                    else
                    {
                        
                     Console.WriteLine("error");
                      
                    }
                    break;
                case "Varna":
                    if (saled >= 0 && saled <= 500)
                    {
                        commision = saled * 0.045;
                    }
                    else if (saled > 500 && saled <= 1000)
                    {
                        commision = saled * 0.075;
                    }
                    else if (saled > 1000 && saled <= 10000)
                    {
                        commision = saled * 0.1;
                    }
                    else if (saled > 10000)
                    {
                        commision = saled * 0.13;
                    }
                    else
                    {

                        Console.WriteLine("error");
                       
                    }
                    break;
                case "Plovdiv":
                    if (saled >= 0 && saled <= 500)
                    {
                        commision = saled * 0.055;
                    }
                    else if (saled > 500 && saled <= 1000)
                    {
                        commision = saled * 0.08;
                    }
                    else if (saled > 1000 && saled <= 10000)
                    {
                        commision = saled * 0.12;
                    }
                    else if (saled > 10000)
                    {
                        commision = saled * 0.145;
                    }
                    else
                    {

                        Console.WriteLine("error");
                        
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if(commision > 0)
            {
                Console.WriteLine($"{commision:F2}");
            }
        }
    }
}
