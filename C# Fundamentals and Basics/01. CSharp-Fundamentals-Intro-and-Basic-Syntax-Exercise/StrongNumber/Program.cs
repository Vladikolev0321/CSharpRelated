using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = num;
            int sum = 0;
            while(num>0)
            {
                int subnum = num % 10;
                num = num / 10;
             //   Console.WriteLine($"NUM:{num}");
                int sumInside = 1;
                for(int i = 1; i <= subnum; i++)
                {
                    sumInside *= i;
                }
                sum += sumInside;

               // Console.WriteLine($"SumInside:{sumInside}");
              //  Console.WriteLine($"Sum:{sum}");

            }
            if (sum == num1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
