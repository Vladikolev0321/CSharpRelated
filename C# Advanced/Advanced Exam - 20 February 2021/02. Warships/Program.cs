using System;
using System.Linq;

namespace _02._Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];



            string[] commmands = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = row[j];
                }
            }
            // int countDestrByP1 = 0;
            // int countDestrByP2 = 0;'
            int countDestr = 0;
            int countP1Ships = 0;
            int countP2Ships = 0;

            countP1Ships = GetCountP1Ships(n, field, countP1Ships);
            countP2Ships = GetCountP2Ships(n, field, countP2Ships);

            for (int i = 0; i < commmands.Length; i++)
            {
                int x, y;
                /*if (commmands[i].Length == 1)
                {
                    x = int.Parse(commmands[i]);
                    y = int.Parse(commmands[i]);
                }
                */
               // else
                //{

                    int[] coordinates = commmands[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    x = coordinates[0];
                    y = coordinates[1];

                //}


                if (x < 0 || x >= n || y < 0 || y >= n)
                {
                    continue;
                }
                ///player 1
                if (i % 2 == 0)
                {
                    commandsForP1(n, field, ref countDestr, ref countP1Ships, ref countP2Ships, x, y, true);
                }
                //p2
                else
                {
                    commandsForP1(n, field, ref countDestr, ref countP1Ships, ref countP2Ships, x, y, false);

                }
                if (countP1Ships == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {countDestr} ships have been sunk in the battle.");
                    break;
                }
                else if (countP2Ships == 0)
                {
                    Console.WriteLine($"Player One has won the game! {countDestr} ships have been sunk in the battle.");
                    break;
                }

            /*    Console.WriteLine();
                PrintField(n, field);
              */ 

            }
            Console.WriteLine();
            PrintField(n, field);
            
            if (countP1Ships != 0 && countP2Ships != 0)
            {
                Console.WriteLine($"It's a draw! Player One has {countP1Ships} ships left. Player Two has {countP2Ships} ships left.");
            }

        }

       
        private static void commandsForP1(int n, char[,] field, ref int countDestr, ref int countP1Ships, ref int countP2Ships, int x, int y, bool isP1)
        {
            if(isP1 == true)
            {
                if (field[x, y] == '>')
                {
                    countDestr++;
                    field[x, y] = 'X';
                    countP2Ships--;
                }
            }
            else
            {
                if (field[x, y] == '<')
                {
                    countDestr++;
                    field[x, y] = 'X';
                    countP1Ships--;
                }
            }
            if (field[x, y] == '#')
            {
                //up
                if (x - 1 >= 0)
                {
                    if (field[x - 1, y] == '>')
                    {
                        countDestr++;
                        countP2Ships--;

                        field[x - 1, y] = 'X';
                    }
                    else if (field[x - 1, y] == '<')
                    {
                        countDestr++;
                        countP1Ships--;

                        field[x - 1, y] = 'X';
                    }

                    //up right
                    if (y + 1 < n)
                    {
                        if (field[x - 1, y + 1] == '>')
                        {
                            countDestr++;
                            countP2Ships--;

                            field[x - 1, y + 1] = 'X';
                        }
                        else if (field[x - 1, y + 1] == '<')
                        {
                            countDestr++;
                            countP1Ships--;

                            field[x - 1, y + 1] = 'X';
                        }
                    }
                    //up left
                    if (y - 1 >= 0)
                    {
                        if (field[x - 1, y - 1] == '>')
                        {
                            countDestr++;
                            countP2Ships--;

                            field[x - 1, y - 1] = 'X';
                        }
                        else if (field[x - 1, y - 1] == '<')
                        {
                            countDestr++;
                            countP1Ships--;

                            field[x - 1, y - 1] = 'X';
                        }
                    }

                }
                //down
                if (x + 1 < n)
                {
                    if (field[x + 1, y] == '>')
                    {
                        countDestr++;
                        countP2Ships--;


                        field[x + 1, y] = 'X';
                    }
                    else if (field[x + 1, y] == '<')
                    {
                        countDestr++;
                        countP1Ships--;


                        field[x + 1, y] = 'X';
                    }

                    //down right
                    if (y + 1 < n)
                    {
                        if (field[x + 1, y + 1] == '>')
                        {
                            countDestr++;
                            countP2Ships--;

                            field[x + 1, y + 1] = 'X';
                        }
                        else if (field[x + 1, y + 1] == '<')
                        {
                            countDestr++;
                            countP1Ships--;

                            field[x + 1, y + 1] = 'X';
                        }
                    }
                    //down left
                    if (y - 1 >= 0)
                    {
                        if (field[x + 1, y - 1] == '>')
                        {
                            countDestr++;
                            countP2Ships--;

                            field[x + 1, y - 1] = 'X';
                        }
                        else if (field[x + 1, y - 1] == '<')
                        {
                            countDestr++;
                            countP1Ships--;

                            field[x + 1, y - 1] = 'X';
                        }
                    }

                }
                //left
                if (y - 1 >= 0)
                {
                    if (field[x, y - 1] == '>')
                    {
                        countDestr++;
                        countP2Ships--;


                        field[x, y - 1] = 'X';
                    }
                    else if (field[x, y - 1] == '<')
                    {
                        countDestr++;
                        countP1Ships--;


                        field[x, y - 1] = 'X';
                    }
                }
                //right
                if (y + 1 < n)
                {
                    if (field[x, y + 1] == '>')
                    {
                        countDestr++;
                        countP2Ships--;

                        field[x, y + 1] = 'X';
                    }
                    else if (field[x, y + 1] == '<')
                    {
                        countDestr++;
                        countP1Ships--;

                        field[x, y + 1] = 'X';
                    }
                }

                field[x, y] = 'X';
            }
        }

        private static void PrintField(int n, char[,] field)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        private static int GetCountP2Ships(int n, char[,] field, int countP2Ships)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (field[i, j] == '>')
                    {
                        countP2Ships++;
                    }
                }
            }

            return countP2Ships;
        }

        private static int GetCountP1Ships(int n, char[,] field, int countP1Ships)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (field[i, j] == '<')
                    {
                        countP1Ships++;
                    }
                }
            }

            return countP1Ships;
        }
    }
}
