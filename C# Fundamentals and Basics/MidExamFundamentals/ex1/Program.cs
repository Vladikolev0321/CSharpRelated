using System;
using System.Text;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //StringBuilder sb = new StringBuilder();

            double totalPrice = 0;
            for (int i = 0; i < N; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double currPrice = Math.Round(((days * capsulesCount) * pricePerCapsule),2);
                totalPrice += currPrice;

                Console.WriteLine($"The price for the coffee is: ${currPrice:F2}");
                //sb.AppendLine($"The price for the coffee is: ${Math.Round(currPrice,2):F2}");
            }
            //Console.WriteLine(sb.ToString().TrimEnd());
            Console.WriteLine($"Total: ${Math.Round(totalPrice,2):F2}");
        }
    }
}
