using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var productShop = new Dictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();
            while(input != "Revision")
            {
                string[] inputInfo = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shopName = inputInfo[0];
                string productName = inputInfo[1];
                double productPrice = double.Parse(inputInfo[2]);

                if(!productShop.ContainsKey(shopName))
                {
                    productShop.Add(shopName, new Dictionary<string, double>());
                }
                if(!productShop[shopName].ContainsKey(productName))
                {
                    productShop[shopName].Add(productName, 0);
                }
                productShop[shopName][productName] = productPrice;
                

                input = Console.ReadLine();
            }
            foreach (var (shopName,products) in productShop.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shopName}->");
                foreach (var currentProduct in products)
                {
                    Console.WriteLine($"Product:{currentProduct.Key},price:{currentProduct.Value:F1}");
                }
            }
        }

    }
}
