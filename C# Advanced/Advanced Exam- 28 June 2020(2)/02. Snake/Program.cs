using System;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string currRow = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = currRow[j];
                }
            }

            int snakeRow = -1;
            int snakeCol = -1;

            getSnakeCoordinates(n, field, ref snakeRow, ref snakeCol);

            int countFood = 0;
            bool isOut = false;
            while (countFood < 10 && isOut == false)
            {
                string command = Console.ReadLine();
                field[snakeRow, snakeCol] = '.';
                if(command == "up")
                {
                    if(snakeRow - 1 < 0)
                    {
                        isOut = true;
                        continue;
                    }
                    checkPos(field, snakeRow - 1, snakeCol, ref countFood, n, ref snakeRow, ref snakeCol);
                    field[snakeRow, snakeCol] = 'S';
                }
                else if(command == "down")
                {
                    if(snakeRow + 1 == n)
                    {
                        isOut = true;
                        continue;
                    }
                    checkPos(field, snakeRow + 1, snakeCol, ref countFood, n, ref snakeRow, ref snakeCol);
                    field[snakeRow, snakeCol] = 'S';
                }
                else if (command == "left")
                {
                    if (snakeCol - 1 < 0)
                    {
                        isOut = true;
                        continue;
                    }
                    checkPos(field, snakeRow, snakeCol - 1, ref countFood, n, ref snakeRow, ref snakeCol);
                    field[snakeRow, snakeCol] = 'S';
                }
                else
                {
                    if (snakeCol + 1 == n)
                    {
                        isOut = true;
                        continue;
                    }
                    checkPos(field, snakeRow, snakeCol + 1, ref countFood, n, ref snakeRow, ref snakeCol);
                    field[snakeRow, snakeCol] = 'S';
                }

            }

            if(isOut == true)
            {
                Console.WriteLine("Game over!");
            }
            if(countFood >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {countFood}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
            
        }
        public static void checkPos(char[,] field, int changedRow, int changedCol, ref int foodQuantity,
                                    int n, ref int snakeRow, ref int snakeCol)
        {
            if(field[changedRow, changedCol] == '*')
            {
                foodQuantity++;
                snakeRow = changedRow;
                snakeCol = changedCol;
            }
            else if(field[changedRow, changedCol] == 'B')
            {
                field[changedRow, changedCol] = '.';
                int burrowRow = -1;
                int burrowCol = -1;
                for(int row = 0; row < n; row++)
                {
                    for(int col = 0; col < n; col++)
                    {
                        if(field[row, col] == 'B')
                        {
                            burrowRow = row;
                            burrowCol = col;
                        }
                    }
                }
                snakeRow = burrowRow;
                snakeCol = burrowCol;
            }
            else
            {
                snakeRow = changedRow;
                snakeCol = changedCol;
            }
        }
        public static void getSnakeCoordinates(int n, char[,] field, ref int snakeRow, ref int snakeCol)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(field[i, j] == 'S')
                    {
                        snakeRow = i;
                        snakeCol = j;
                    }
                }
            }
        }
    }
}
