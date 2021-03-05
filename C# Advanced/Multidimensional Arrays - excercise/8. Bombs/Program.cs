using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];
            InicialisingMatrix(N, matrix);

            string[] bombInfo = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < bombInfo.Length; i++)
            {
                int[] bombArgs = bombInfo[i]
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int row = bombArgs[0];
                int col = bombArgs[1];
                if (matrix[row, col] <= 0)
                {
                    continue;
                }
                int damage = matrix[row, col];
                matrix[row, col] = 0;
                if (row - 1 >= 0)
                {
                    if (IsAlive(matrix, row - 1, col))
                    {
                        matrix[row - 1, col] -= damage;
                    }
                }
                if (row + 1 < N)
                {
                    if (IsAlive(matrix, row + 1, col))
                    {
                        matrix[row + 1, col] -= damage;
                    }

                }
                if (col - 1 >= 0)
                {
                    if (IsAlive(matrix, row, col - 1))
                    {
                        matrix[row, col - 1] -= damage;
                    }
                }
                if (col + 1 < N)
                {
                    if (IsAlive(matrix, row, col + 1))
                    {
                        matrix[row, col + 1] -= damage;
                    }

                }
                if (col - 1 >= 0 && row - 1 >= 0)
                {
                    if (IsAlive(matrix, row - 1, col - 1))
                    {
                        matrix[row - 1, col - 1] -= damage;
                    }

                }
                if (col + 1 < N && row - 1 >= 0)
                {
                    if (IsAlive(matrix, row - 1, col + 1))
                    {
                        matrix[row - 1, col + 1] -= damage;
                    }

                }
                if (row + 1 < N && col - 1 >= 0)
                {
                    if (IsAlive(matrix, row + 1, col - 1))
                    {
                        matrix[row + 1, col - 1] -= damage;
                    }

                }
                if (row + 1 < N && col + 1 < N)
                {
                    if (IsAlive(matrix, row + 1, col + 1))
                    {
                        matrix[row + 1, col + 1] -= damage;
                    }

                }


            }
            int aliveCells = 0;
            int sumOfAliveCells = 0;

            aliveCells = FindingAliveCells(N, matrix, aliveCells);
            sumOfAliveCells = FindingSumOfAliveCells(N, matrix, sumOfAliveCells);

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumOfAliveCells}");

            PrintMatrix(N, matrix);

        }

        private static int FindingSumOfAliveCells(int N, int[,] matrix, int sumOfAliveCells)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (IsAlive(matrix, row, col))
                    {
                        sumOfAliveCells += matrix[row, col];
                    }
                }
            }

            return sumOfAliveCells;
        }

        private static int FindingAliveCells(int N, int[,] matrix, int aliveCells)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (IsAlive(matrix, row, col))
                    {
                        aliveCells++;
                    }
                }
            }

            return aliveCells;
        }

        private static bool IsAlive(int [,] matrix , int row , int col)
        {
            if(matrix[row,col] > 0)
            {
                return true;
            }
            return false;
        }

        private static void PrintMatrix(int N, int[,] matrix)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void InicialisingMatrix(int N, int[,] matrix)
        {
            for (int row = 0; row < N; row++)
            {
                int[] currRow = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }
        }

    }
}
