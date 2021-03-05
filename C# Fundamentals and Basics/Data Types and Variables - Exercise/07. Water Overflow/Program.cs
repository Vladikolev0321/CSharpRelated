using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sumQuantity = 0;
            for (int i = 0; i < n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if (quantity > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= quantity;
                    sumQuantity += quantity;
                }
            }
            Console.WriteLine(sumQuantity);
        }
    }
}
