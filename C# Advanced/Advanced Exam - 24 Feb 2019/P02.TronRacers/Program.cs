using System;
using System.Runtime.Serialization;

namespace P02.TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            char[,] field = new char[N, N];
            InitField(N, field);

            int firstRow = -1;
            int firstCol = -1;
            FindingFirstPlayerCoordinates(N, field, ref firstRow, ref firstCol);
            int secondRow = -1;
            int secondCol = -1;
            FindingSecondPlayerCoordinates(N, field, ref secondRow, ref secondCol);


            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string firstCommand = commands[0];
                string secondCommand = commands[1];

                if (firstCommand == "up")
                {
                    if (firstRow - 1 < 0)
                    {
                        if (field[N - 1, firstCol] == 's')
                        {
                            field[N - 1, firstCol] = 'x';
                            break;
                        }
                        else
                        {
                            firstRow = N - 1;
                            field[N - 1, firstCol] = 'f';
                        }
                    }
                    else
                    {
                        if (field[firstRow - 1, firstCol] == 's')
                        {
                            field[firstRow - 1, firstCol] = 'x';
                            break;
                        }
                        else
                        {
                            field[firstRow - 1, firstCol] = 'f';
                            firstRow--;
                        }
                    }


                }
                else if (firstCommand == "down")
                {
                    if (firstRow + 1 == N)
                    {
                        if (field[0, firstCol] == 's')
                        {
                            field[0, firstCol] = 'x';
                            break;
                        }
                        else
                        {
                            firstRow = 0;
                            field[0, firstCol] = 'f';
                        }
                    }
                    else
                    {
                        if (field[firstRow + 1, firstCol] == 's')
                        {
                            field[firstRow + 1, firstCol] = 'x';
                            break;
                        }
                        else
                        {
                            field[firstRow + 1, firstCol] = 'f';
                            firstRow++;
                        }
                    }
                }
                else if (firstCommand == "left")
                {
                    if (firstCol - 1 < 0)
                    {
                        if (field[firstRow, N - 1] == 's')
                        {
                            field[firstRow, N - 1] = 'x';
                            break;
                        }
                        else
                        {
                            firstCol = N - 1;
                            field[firstRow, firstCol] = 'f';
                        }
                    }
                    else
                    {
                        if (field[firstRow, firstCol - 1] == 's')
                        {
                            field[firstRow, firstCol - 1] = 'x';
                            break;
                        }
                        else
                        {
                            field[firstRow, firstCol - 1] = 'f';
                            firstCol--;
                        }
                    }
                }
                else if (firstCommand == "right")
                {
                    if (firstCol + 1 == N)
                    {
                        if (field[firstRow, 0] == 's')
                        {
                            field[firstRow, 0] = 'x';
                            break;
                        }
                        else
                        {
                            firstCol = 0;
                            field[firstRow, 0] = 'f';
                        }
                    }
                    else
                    {
                        if (field[firstRow, firstCol + 1] == 's')
                        {
                            field[firstRow, firstCol + 1] = 'x';
                            break;
                        }
                        else
                        {
                            field[firstRow, firstCol + 1] = 'f';
                            firstCol++;
                        }
                    }
                }

                /////Second
                if (secondCommand == "up")
                {
                    if (secondRow - 1 < 0)
                    {
                        if (field[N - 1, secondCol] == 'f')
                        {
                            field[N - 1, secondCol] = 'x';
                            break;
                        }
                        else
                        {
                            secondRow = N - 1;
                            field[N - 1, secondCol] = 's';
                        }
                    }
                    else
                    {
                        if (field[secondRow - 1, secondCol] == 'f')
                        {
                            field[secondRow - 1, secondCol] = 'x';
                            break;
                        }
                        else
                        {
                            field[secondRow - 1, secondCol] = 's';
                            secondRow--;
                        }
                    }


                }
                else if (secondCommand == "down")
                {
                    if (secondRow + 1 == N)
                    {
                        if (field[0, secondCol] == 'f')
                        {
                            field[0, secondCol] = 'x';
                            break;
                        }
                        else
                        {
                            secondRow = 0;
                            field[0, secondCol] = 's';
                        }
                    }
                    else
                    {
                        if (field[secondRow + 1, secondCol] == 'f')
                        {
                            field[secondRow + 1, secondCol] = 'x';
                            break;
                        }
                        else
                        {
                            field[secondRow + 1, secondCol] = 's';
                            secondRow++;
                        }
                    }
                }
                else if (secondCommand == "left")
                {
                    if (secondCol - 1 < 0)
                    {
                        if (field[secondRow, N - 1] == 'f')
                        {
                            field[secondRow, N - 1] = 'x';
                            break;
                        }
                        else
                        {
                            secondCol = N - 1;
                            field[secondRow, secondCol] = 's';
                        }
                    }
                    else
                    {
                        if (field[secondRow, secondCol - 1] == 'f')
                        {
                            field[secondRow, secondCol - 1] = 'x';
                            break;
                        }
                        else
                        {
                            field[secondRow, secondCol - 1] = 's';
                            secondCol--;
                        }
                    }
                }
                else if (secondCommand == "right")
                {
                    if (secondCol + 1 == N)
                    {
                        if (field[secondRow, 0] == 'f')
                        {
                            field[secondRow, 0] = 'x';
                            break;
                        }
                        else
                        {
                            secondCol = 0;
                            field[secondRow, 0] = 's';
                        }
                    }
                    else
                    {
                        if (field[secondRow, secondCol + 1] == 'f')
                        {
                            field[secondRow, secondCol + 1] = 'x';
                            break;
                        }
                        else
                        {
                            field[secondRow, secondCol + 1] = 's';
                            secondCol++;
                        }
                    }
                }
                //PrintField(N, field);

            }
            PrintField(N, field);

        }

        private static void PrintField(int N, char[,] field)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void FindingSecondPlayerCoordinates(int N, char[,] field, ref int secondRow, ref int secondCol)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (field[row, col] == 's')
                    {
                        secondRow = row;
                        secondCol = col;
                    }
                }
            }
        }

        private static void FindingFirstPlayerCoordinates(int N, char[,] field, ref int firstRow, ref int firstCol)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (field[row, col] == 'f')
                    {
                        firstRow = row;
                        firstCol = col;
                    }
                }
            }
        }

        private static void InitField(int N, char[,] field)
        {
            for (int row = 0; row < N; row++)
            {
                string currRow = Console.ReadLine();
                for (int col = 0; col < N; col++)
                {
                    field[row, col] = currRow[col];
                }
            }
        }
    }
}
