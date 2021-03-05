using System;
using System.Numerics;

namespace _3.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger bigInteger = 1;
            //50

            //50* 49 * 48

            for (int i = number ; i > 0; i--)
            {
                bigInteger *= i;
            }
            Console.WriteLine(bigInteger);
        }
    }
}
