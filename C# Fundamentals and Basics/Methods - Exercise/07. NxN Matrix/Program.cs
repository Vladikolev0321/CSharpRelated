using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);

        }
        static void PrintMatrix(int n)
        {
            for (int i = 1; i <= n;i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
