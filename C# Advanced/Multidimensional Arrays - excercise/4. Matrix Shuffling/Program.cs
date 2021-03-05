using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                   // .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }


            while (true)
            {
                string command = Console.ReadLine();
                if(command == "END")
                {
                    break;
                }
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if(cmdArgs[0] == "swap" && cmdArgs.Length == 5)
                {
                    int x1 = int.Parse(cmdArgs[1]);
                    int x2 = int.Parse(cmdArgs[2]);
                    int y1 = int.Parse(cmdArgs[3]);
                    int y2 = int.Parse(cmdArgs[4]);

                    if (!AreCoordinatesValid(x1, x2, y1, y2, rows, cols))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string temp = matrix[x1, x2];
                    matrix[x1, x2] = matrix[y1, y2];
                    matrix[y1, y2] = temp;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row,col] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                
            }
        }
        private static bool AreCoordinatesValid(int x1,int x2,int y1, int y2,int rowsLength,int colsLength)
        {
            if(x1 < 0 || x1 > rowsLength -1 || x2 < 0 || x2 > colsLength - 1
                || y1 < 0 || y1 > rowsLength - 1 || y2 < 0 || y2 > colsLength - 1)
            {
                return false;
            }
            return true;
        }
    }
}
