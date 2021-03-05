using System;

namespace _02.Bee
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
            int count_pollinated = 0;
            bool isOut = false;
            string command;
            while (isOut != true)
            {
                if ((command = Console.ReadLine()) == "End")
                {
                    break;
                }
                if (command == "up")
                {
                    if (move_bee(n, "up", ref field, beeRow - 1, beeCol,
                        ref beeRow, ref beeCol, ref count_pollinated, ref isOut) == false)
                    {
                        continue;
                    }
                }
                else if (command == "down")
                {
                    if (move_bee(n, "down", ref field, beeRow + 1, beeCol,
                        ref beeRow, ref beeCol, ref count_pollinated, ref isOut) == false)
                    {
                        continue;
                    }
                }
                else if (command == "left")
                {
                    if (move_bee(n, "left", ref field, beeRow, beeCol - 1,
                        ref beeRow, ref beeCol, ref count_pollinated, ref isOut) == false)
                    {
                        continue;
                    }
                }
                else if (command == "right")
                {
                    if (move_bee(n, "right", ref field, beeRow, beeCol + 1,
                        ref beeRow, ref beeCol, ref count_pollinated, ref isOut) == false)
                    {
                        continue;
                    }
                }
                PrintField(n, field);
                Console.WriteLine();
            }

            if (isOut)
            {
                Console.WriteLine("The bee got lost!");
            }
            if (count_pollinated >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {count_pollinated} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - count_pollinated} flowers more");
            }

            PrintField(n, field);
        }

        private static void PrintField(int n, char[,] field)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static bool move_bee(int n, string command, ref char[,] field, int changedRow, int changedCol,
            ref int beeRow, ref int beeCow, ref int count_pollinated, ref bool isOut)
        {

            field[beeRow, beeCow] = '.';///no
            if (changedRow < 0 || changedRow == n || changedCol < 0 || changedCol == n)
            {
                isOut = true;
                return false;
            }

            if(field[changedRow, changedCol] == 'f')
            {
                count_pollinated++;
            }
            else if(field[changedRow, changedCol] == 'O')
            {
                field[changedRow, changedCol] = '.';
                if (command == "up")/// check if it is out
                {
                    move_bee(n, "up", ref field, changedRow - 1, changedCol, ref beeRow, ref beeCow, ref count_pollinated, ref isOut);
                }
                else if(command == "down")
                {
                    move_bee(n, "down", ref field, changedRow + 1, changedCol, ref beeRow, ref beeCow, ref count_pollinated, ref isOut);
                }
                else if(command == "left")
                {
                    move_bee(n, "left", ref field, changedRow, changedCol - 1, ref beeRow, ref beeCow, ref count_pollinated, ref isOut);
                }
                else
                {
                    move_bee(n, "right", ref field, changedRow, changedCol + 1, ref beeRow, ref beeCow, ref count_pollinated, ref isOut);
                }
            }
            else
            {
                //just move 
            }
            field[changedRow, changedCol] = 'B';
            beeRow = changedRow;
            beeCow = changedCol;

            return true;
        }
       
    }
}
