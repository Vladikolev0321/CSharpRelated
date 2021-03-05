using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>\w+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

            List<string> purchasedFurniture = new List<string>();
            decimal moneySpend = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Purchase")
                {
                    break;
                }
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    purchasedFurniture.Add(name);
                    moneySpend += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            if (purchasedFurniture.Count > 0)
            {
            Console.WriteLine(string.Join(Environment.NewLine, purchasedFurniture));

            }

            Console.WriteLine($"Total money spend: {moneySpend:F2}");

        }
    }
}
