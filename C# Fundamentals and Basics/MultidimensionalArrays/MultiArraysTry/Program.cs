using System;
using System.Linq;
namespace MultiArraysTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { {1,2,3,4},{5,6,7,8} };
           /////Accesing elements of the array
           // Console.WriteLine(matrix[1, 2]);
            ///array.GetLenght(dimension)

            /////Printing the multidimensional arrays
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("SECOND METHOD FOR PRINTING THIS TYPE OF ARRAY");

            foreach(int el in matrix)
            {
                Console.Write($"{el} ");
            }

        }
    }
}
