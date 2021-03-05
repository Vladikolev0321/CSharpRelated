using System;
using System.Linq;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] array = new int[4][];

            //array[0] = new int[3];
            //array[1] = new int[2];
            //array[2] = new int[4];
            //array[3] = new int[1];

            /////FILLING JAGGED ARRAY
            ///

            /*
            1 2 3 4
            5 6
            7 8 9 10 11
                */


            int rows = int.Parse(Console.ReadLine());


            int[][] array = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                array[row] = currentRow;

            }
            for (int row = 0; row < array.Length; row++)
            {
                int[] currentRow = array[row];
                for (int col = 0; col < currentRow.Length; col++)
                {
                    Console.Write(array[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
