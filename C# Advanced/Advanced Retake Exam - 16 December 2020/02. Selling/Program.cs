using System;

namespace _02._Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = row[j];
                }
            }

            int yourRow = -1;
            int yourCol = -1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (field[i, j] == 'S')
                    {
                        yourRow = i;
                        yourCol = j;
                    }
                }
            }
            int collectedMoney = 0;
            while(collectedMoney < 50)
            {
                string command = Console.ReadLine();
                field[yourRow, yourCol] = '-';
                yourRow = MoveX(yourRow, command);
                yourCol = MoveY(yourCol, command);

                if (yourRow < 0 || yourRow >= n || yourCol < 0 || yourCol >= n)
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }

                if(field[yourRow, yourCol] == 'O')
                {
                    field[yourRow, yourCol] = '-';
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (field[i, j] == 'O')
                            {
                                yourRow = i;
                                yourCol = j;
                            }
                        }
                    }
                }
                else if(field[yourRow, yourCol] == '-')
                {

                }
                else
                {
                    collectedMoney += int.Parse(field[yourRow, yourCol].ToString());
                }
                field[yourRow, yourCol] = 'S';
               
            }

            if(collectedMoney >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            Console.WriteLine($"Money: {collectedMoney}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static int MoveX(int beeRow, string command)
        {
            if (command == "up")
            {
                beeRow -= 1;
            }
            else if (command == "down")
            {
                beeRow += 1;
            }

            return beeRow;
        }
        private static int MoveY(int beeCol, string command)
        {
            if (command == "left")
            {
                beeCol -= 1;
            }
            else if (command == "right")
            {
                beeCol += 1;
            }

            return beeCol;
        }
    }
}
