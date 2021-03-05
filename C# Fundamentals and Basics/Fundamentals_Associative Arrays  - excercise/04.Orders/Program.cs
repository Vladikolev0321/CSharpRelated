using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string,Dictionary<int,int>> d

            Dictionary<string, double> productPrices = new Dictionary<string, double>();
            Dictionary<string, int> productQuant = new Dictionary<string, int>();

            while (true)
            {
                string inp = Console.ReadLine();
                if(inp == "buy")
                {
                    break;
                }

                string[] productArgs = inp.Split().ToArray();

                string name = productArgs[0];
                double price = double.Parse(productArgs[1]);
                int quant = int.Parse(productArgs[2]);

                if (!productQuant.ContainsKey(name))
                {
                    productQuant[name] = 0;
                    productQuant[name] = 0;
                }
                productQuant[name] += quant;
                productPrices[name] = price;

            }

            foreach (var kvp in productPrices)
            {
                string name = kvp.Key;
                double price = kvp.Value;
                int quantity = productQuant[name];

                Console.WriteLine($"{name} -> {price*quantity:F2}");
            }
        }
    }
}
