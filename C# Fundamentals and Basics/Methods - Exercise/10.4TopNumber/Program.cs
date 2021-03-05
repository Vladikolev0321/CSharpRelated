using System;

namespace _10._4TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            isTopNumber(n);
        }
        static void isTopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int num = i;
                bool hasOddDigit = false;
                while (num > 0)
                {
                    sum += num % 10;
                    int digit = num % 10;
                    if(digit % 2 != 0)
                    {
                        hasOddDigit = true;
                    }
                    num /= 10;
                }
                if(sum % 8 == 0 && hasOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
