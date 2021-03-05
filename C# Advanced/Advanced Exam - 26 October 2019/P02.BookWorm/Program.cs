using System;
using System.Linq;
using System.Text;

namespace P02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string receivedString = Console.ReadLine();
            StringBuilder initialString = new StringBuilder();
            initialString.Append(receivedString);

            int N = int.Parse(Console.ReadLine());
            char[,] field = new char[N, N];
            InitField(N, field);

            int playerRow = -1;
            int playerCol = -1;

            //Finding player's row and col
            FindPlayerRowCol(N, field, ref playerRow, ref playerCol);

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "up")
                {
                    if (playerRow - 1 < 0)
                    {
                        initialString.Remove(initialString.Length - 1, 1);
                    }
                    else
                    {
                        field[playerRow, playerCol] = '-';
                        char currChar = field[playerRow - 1, playerCol];
                        if (char.IsLetter(currChar))
                        {
                            initialString.Append(currChar);
                        }
                        field[playerRow - 1, playerCol] = 'P';

                        playerRow -= 1;
                    }
                }
                else if (command == "down")
                {
                    if (playerRow + 1 == N)
                    {
                        initialString.Remove(initialString.Length - 1, 1);
                    }
                    else
                    {
                        field[playerRow, playerCol] = '-';
                        char currChar = field[playerRow + 1, playerCol];
                        if (char.IsLetter(currChar))
                        {
                            initialString.Append(currChar);
                        }
                        field[playerRow + 1, playerCol] = 'P';

                        playerRow += 1;
                    }
                }
                else if (command == "left")
                {
                    if (playerCol - 1 < 0)
                    {
                        initialString.Remove(initialString.Length - 1, 1);
                    }
                    else
                    {
                        field[playerRow, playerCol] = '-';
                        char currChar = field[playerRow, playerCol - 1];
                        if (char.IsLetter(currChar))
                        {
                            initialString.Append(currChar);
                        }
                        field[playerRow, playerCol - 1] = 'P';

                        playerCol -= 1;
                    }
                }
                else if (command == "right")
                {
                    if (playerCol + 1 == N)
                    {
                        initialString.Remove(initialString.Length - 1, 1);
                    }
                    else
                    {
                        field[playerRow, playerCol] = '-';
                        char currChar = field[playerRow, playerCol + 1];
                        if (char.IsLetter(currChar))
                        {
                            initialString.Append(currChar);
                        }
                        field[playerRow, playerCol + 1] = 'P';

                        playerCol += 1;

                    }
                }
            }

            Console.WriteLine(initialString);
            PrintMatrix(N, field);

        }

        private static void PrintMatrix(int N, char[,] field)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    Console.Write($"{field[row, col]}");
                }
                Console.WriteLine();
            }
        }

        private static void FindPlayerRowCol(int N, char[,] field, ref int playerRow, ref int playerCol)
        {
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
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
