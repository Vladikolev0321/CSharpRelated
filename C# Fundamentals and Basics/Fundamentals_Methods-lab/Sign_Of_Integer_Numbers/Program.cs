using System;
using System.Net;

namespace Sign_Of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }
        
        static void PrintSign(int n)
        {
            if(n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if( n< 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}
