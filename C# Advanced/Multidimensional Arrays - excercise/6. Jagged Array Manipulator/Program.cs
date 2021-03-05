using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] arr = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                arr[row] = new double[currRow.Length];
                for (int col = 0; col < arr[row].Length; col++)
                {
                    arr[row][col] = currRow[col];
                }

            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (arr[row + 1].Length == arr[row].Length)
                {
                    arr[row + 1] = arr[row + 1].Select(x => x * 2).ToArray();
                    arr[row] = arr[row].Select(x => x * 2).ToArray();

                }
                else
                {
                    arr[row + 1] = arr[row + 1].Select(x => x / 2).ToArray();
                    arr[row] = arr[row].Select(x => x / 2).ToArray();
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "End")
                {
                    break;
                }
                string[] cmdArgs = command.Split();
                if(cmdArgs[0] == "Add")
                {
                    int row = int.Parse(cmdArgs[1]);
                    int col = int.Parse(cmdArgs[2]);
                    int value = int.Parse(cmdArgs[3]);
                    if(row >= 0 && row < rows && col >= 0 && col < arr[row].Length)
                    {
                        arr[row][col] += value;
                    }
                }
                else if(cmdArgs[0] == "Subtract")
                {
                    int row = int.Parse(cmdArgs[1]);
                    int col = int.Parse(cmdArgs[2]);
                    int value = int.Parse(cmdArgs[3]);
                    if (row >= 0 && row < rows && col >= 0 && col < arr[row].Length)
                    {
                        arr[row][col] -= value;
                    }
                }
            }

            PrintArr(arr);

        }

        private static void PrintArr(double[][] arr)
        {
            foreach (var row in arr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
