using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintCharactersInRange(start, end);
        }
        static void PrintCharactersInRange(char start , char end)
        {
            int IntStart = (int)start;
            int IntEnd = (int)end;
            //Console.WriteLine(IntStart);
            //Console.WriteLine(IntEnd);
            if (IntStart < IntEnd)
            {
                for (int i = IntStart + 1; i < IntEnd; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = IntEnd + 1; i < IntStart; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }

        }
    }
}
