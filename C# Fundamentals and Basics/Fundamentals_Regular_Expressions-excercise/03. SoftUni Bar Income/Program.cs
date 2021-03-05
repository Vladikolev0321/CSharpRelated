using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = 0;
            //string pattern = @"%(?<name>[A-z][a-z]+)%[^|$%.]*<(?<productName>[\w]+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*(?<price>\d+(\.\d+)?)\$";
            // string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<productName>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            string pattern = @"%(?<name>[A-z][a-z]+)%[^|$%.]*<(?<productName>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$";
            //string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end of shift")
                {
                    break;
                }

                if (Regex.IsMatch(input, pattern))
                {
                    var match = Regex.Match(input, pattern);
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["productName"].Value;
                    double totalPrice = int.Parse(match.Groups["quantity"].Value)
                        * double.Parse(match.Groups["price"].Value);

                    Console.WriteLine($"{name}: {product} - {totalPrice:F2}");

                    income += totalPrice; 

                }
                
            }

            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
