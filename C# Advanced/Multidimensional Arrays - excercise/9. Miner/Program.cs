using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];
            string[] commands = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            InicialisingField(n, field);

            int minerRow = -1;
            int minerCol = -1;
            FindingWhereisTheMiner(n, field, ref minerRow, ref minerCol);

            int coalsInField = 0;
            coalsInField = FindCountOfCoalsInField(n, field, coalsInField);


            int foundCoals = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                string currCommand = commands[i];
                if (currCommand == "left")
                {
                    if (minerCol - 1 >= 0)
                    {
                        CheckWhatCharItIs(field, minerRow, minerCol - 1,
                           ref minerRow, ref minerCol,ref foundCoals,n);
                    }
                }
                else if (currCommand == "right")
                {
                    if (minerCol + 1 < n)
                    {
                        CheckWhatCharItIs(field, minerRow, minerCol + 1,
                            ref minerRow, ref minerCol,ref foundCoals,n);
                    }
                }
                else if (currCommand == "up")
                {
                    if (minerRow - 1 >= 0)
                    {
                        CheckWhatCharItIs(field, minerRow - 1, minerCol,
                            ref minerRow, ref minerCol,ref foundCoals,n);
                    }
                }
                else if (currCommand == "down")
                {
                    if (minerRow + 1 < n)
                    {
                        CheckWhatCharItIs(field, minerRow + 1, minerCol,
                            ref minerRow, ref minerCol,ref foundCoals,n);
                    }
                }

                if (foundCoals == coalsInField)
                {
                    Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                    return;
                }
                //Console.WriteLine();
                //PrintField(n, field);
                //Console.WriteLine();
            }

            Console.WriteLine($"{coalsInField - foundCoals} coals left. ({minerRow}, {minerCol})");


        }

        private static void PrintField(int n, char[,] field)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(field[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void CheckWhatCharItIs(char[,] field,int charRow ,
            int charCol ,ref int minerRow,ref int minerCol,ref int foundCoals,int n)
        {
            if(field[charRow,charCol] == '*')
            {
                field[minerRow, minerCol] = '*';
                field[charRow, charCol] = 's';
                minerRow = charRow;
                minerCol = charCol;
               // FindingWhereisTheMiner(n,field,ref minerRow, ref minerCol);
            }
            else if(field[charRow, charCol] == 'c')
            {
                foundCoals++;
                field[minerRow, minerCol] = '*';
                field[charRow, charCol] = 's';
                minerRow = charRow;
                minerCol = charCol;
                //FindingWhereisTheMiner(n, field, ref minerRow, ref minerCol);

            }
            else if(field[charRow, charCol] == 'e')
            {
                minerRow = charRow;
                minerCol = charCol;
                field[charRow, charCol] = 's';
                Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                Environment.Exit(0);
            }
        }

        private static void FindingWhereisTheMiner(int n, char[,] field, ref int minerRow, ref int minerCol)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                }
            }
        }

        private static int FindCountOfCoalsInField(int n, char[,] field, int coalsInField)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (field[row, col] == 'c')
                    {
                        coalsInField++;
                    }
                }
            }

            return coalsInField;
        }

        private static void InicialisingField(int n, char[,] field)
        {
            for (int row = 0; row < n; row++)
            {
                char[] currRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = currRow[col];
                }
            }
        }
    }
}
