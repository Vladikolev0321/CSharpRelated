using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new 
                Dictionary<string, Dictionary<string, double>>();

            string command;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] cmdArgs = command
                    .Split(", ",StringSplitOptions.RemoveEmptyEntries);

                string shopName = cmdArgs[0];
                string productName = cmdArgs[1];
                double price = double.Parse(cmdArgs[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops[shopName] = new Dictionary<string, double>();                    
                }              
                if (!shops[shopName].ContainsKey(productName))
                {
                    shops[shopName][productName] = 0;
                }
                shops[shopName][productName] = price;
               // shops[shopName].Add(productName, price);
            }

            shops = shops
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in shops)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach (var product in kvp.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
