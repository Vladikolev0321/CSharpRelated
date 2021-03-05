using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            PrintMiddleCharacters(str);
        }

        static void PrintMiddleCharacters(string str)
        {
            if(str.Length % 2 == 0)
            {
                Console.WriteLine($"{str[(str.Length-1)/2]}{str[(str.Length - 1) / 2 + 1]}");
            }
            else
            {
                Console.WriteLine(str[(str.Length - 1) / 2]);
            }
        }
    }
}
