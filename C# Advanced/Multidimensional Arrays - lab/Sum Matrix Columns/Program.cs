using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cmdArgs = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = cmdArgs[0];
            int cols = cmdArgs[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfCurrCol = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfCurrCol += matrix[row, col];
                }
                Console.WriteLine(sumOfCurrCol);
            }
        }
    }
}
