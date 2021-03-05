using System;

namespace _02.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumDigits = 0;
            while (n > 0)
            {
                int sub = n % 10;
                n = n / 10;
                sumDigits += sub;
            }
            Console.WriteLine(sumDigits);
        }
    }
}
