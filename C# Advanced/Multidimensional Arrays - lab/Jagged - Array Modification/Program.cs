using System;
using System.Linq;

namespace Jagged___Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] array = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                array[row] = currentRow;
            }

            while (true)
            {
                string command = Console.ReadLine().ToLower();


                if(command == "end")
                {
                    break;
                }

                string[] cmdArgs = command.Split();

                if(rows<)

                if (cmdArgs[0] == "add")
                {
                }
                else if(cmdArgs[0] == "subtract")
                {

                }
            }
        }
    }
}
