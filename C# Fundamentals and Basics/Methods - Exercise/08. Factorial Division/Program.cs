using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double factoredA = Factor(a);
            double factoredB = Factor(b);
            double res = factoredA / factoredB;
            Console.WriteLine($"{res:F2}");

        }
        static double Factor(int a)
        {
            double res = 1;
            while (a > 0)
            {
                res *= a; 
                a--;
            }
            //Console.WriteLine(res);
            return res;
        }
    }
}
