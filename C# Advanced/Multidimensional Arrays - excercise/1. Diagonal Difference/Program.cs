using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }
            
            int diag1 = 0;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if(row == col)
                    {
                        diag1 += matrix[row,col];
                    }
                    
                }
            }

            int diag2 = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                int row = N - i - 1;
                int col = i;
                diag2 += matrix[row,col];
            }


            Console.WriteLine(Math.Abs(diag1 - diag2));


        }
    }
}
