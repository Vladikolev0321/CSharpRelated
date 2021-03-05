using System;
using System.Linq;
using System.Collections.Generic;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for(int row=0;row<matrix.GetLength(0);row++)
            {
                var col = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int c = 0;c<matrix.GetLength(1);c++)
                {
                    matrix[row, c] = col[c];
                }
            }

            for(int c=0;c<matrix.GetLength(1);c++)
            {
                int sum = 0;
                for(int r = 0;r<matrix.GetLength(0);r++)
                {
                    sum += matrix[r, c];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
