using System;
using System.Numerics;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger startingYield = BigInteger.Parse(Console.ReadLine());
            BigInteger days = 0;
            BigInteger sum = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(sum);

            }
            else
            {
                while (startingYield >= 100)
                {
                    // days++;



                    sum = sum + startingYield - 26;
                    startingYield -= 10;
                    days++;
                } 
            sum -= 26;
            Console.WriteLine(days);
            Console.WriteLine(sum);
            }
            
          
        }
    }
}
