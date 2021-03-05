using System;

namespace _02.Bee_2_
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

            int beeRow = -1;
            int beeCol = -1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (field[i, j] == 'B')
                    {
                        beeRow = i;
                        beeCol = j;
                    }
                }
            }
            int countflowers = 0;
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                field[beeRow, beeCol] = '.';
                beeRow = MoveX(beeRow, command);
                beeCol = MoveY(beeCol, command);

                if (beeRow < 0 || beeRow >= n || beeCol < 0 || beeCol >= n)
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if(field[beeRow, beeCol] == 'f')
                {
                    countflowers++;
                }
                else if(field[beeRow, beeCol] == 'O')
                {
                    field[beeRow, beeCol] = '.';
                    beeRow = MoveX(beeRow, command);
                    beeCol = MoveY(beeCol, command);
                    if (field[beeRow, beeCol] == 'f')
                    {
                        countflowers++;
                    }
                    if (beeRow < 0 || beeRow >= n || beeCol < 0 || beeCol >= n)
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                }

                field[beeRow, beeCol] = 'B';
            }
            if(countflowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - countflowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {countflowers} flowers!");
            }

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
            if(command == "up")
            {
                beeRow -= 1;
            }
            else if(command == "down")
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
