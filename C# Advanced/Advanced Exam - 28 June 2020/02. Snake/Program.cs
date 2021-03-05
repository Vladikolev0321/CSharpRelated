using System;
using System.Runtime.InteropServices;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[,] field = new char[N, N];
            InitField(N, field);

            int snakeRow = -1;
            int snakeCol = -1;
            FindingSnakeCoordinates(N, field, ref snakeRow, ref snakeCol);

            int foodQuantity = 0;
            bool isOut = false;
            while (foodQuantity < 10 && isOut == false)
            {
                string command = Console.ReadLine();
                field[snakeRow, snakeCol] = '.';
                if (command == "up")
                {
                    if (snakeRow - 1 < 0)
                    {
                        isOut = true;
                        continue;
                    }
                    CheckingPositionChar(field, snakeRow - 1, snakeCol, ref foodQuantity, N,ref snakeRow,ref snakeCol);

                    //snakeRow -= 1;

                }
                else if (command == "down")
                {
                    if (snakeRow + 1 == N)
                    {
                        isOut = true;
                        continue;
                    }
                    CheckingPositionChar(field, snakeRow + 1, snakeCol, ref foodQuantity, N, ref snakeRow, ref snakeCol);

                    //snakeRow += 1;
                }
                else if (command == "left")
                {
                    if (snakeCol - 1 < 0)
                    {
                        isOut = true;
                        continue;
                    }
                    CheckingPositionChar(field, snakeRow, snakeCol - 1, ref foodQuantity, N, ref snakeRow, ref snakeCol);

                    //snakeCol -= 1;
                }
                else if (command == "right")
                {
                    if (snakeCol + 1 == N)
                    {
                        isOut = true;
                        continue;
                    }
                    CheckingPositionChar(field, snakeRow, snakeCol + 1, ref foodQuantity, N, ref snakeRow, ref snakeCol);

                    //snakeCol += 1;
                }
               // PrintMatrix(N, field);
            }
            if (isOut)
            {
                Console.WriteLine("Game over!");
            }
            else
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {foodQuantity}");

            PrintMatrix(N, field);
        }

        private static void PrintMatrix(int N, char[,] field)
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

        private static void CheckingPositionChar(char[,] field,int row,int col,
            ref int foodQuantity,int N,ref int snakeRow,ref int snakeCol)
        {
            if (field[row, col] == '*')
            {
                foodQuantity++;
                field[row, col] = 'S';
                snakeRow = row;
                snakeCol = col;
            }
            else if(field[row,col] == 'B')
            {
                field[row, col] = '.';
                int burrowRow = -1;
                int burrowCol = -1;
                for (int row2 = 0; row2 < N; row2++)
                {
                    for (int col2 = 0; col2 < N; col2++)
                    {
                        if(field[row2,col2] == 'B')
                        {
                            burrowRow = row2;
                            burrowCol = col2;
                            break;
                        }
                    }
                }
                field[burrowRow, burrowCol] = 'S';
                //////
                snakeRow = burrowRow;
                snakeCol = burrowCol;
            }
            else
            {

                field[row, col] = 'S';
                snakeRow = row;
                snakeCol = col;
            }
        }

        private static void FindingSnakeCoordinates(int N, char[,] field, ref int snakeRow, ref int snakeCol)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (field[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
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
