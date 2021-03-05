using System;
using System.Linq;

namespace Sum_Matrix_Elements
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

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            long sum = 0;
            foreach (var element in matrix)
            {
                sum += element;
            }
            Console.WriteLine(sum);
        }
    }
}
