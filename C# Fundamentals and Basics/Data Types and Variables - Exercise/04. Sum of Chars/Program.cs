using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int charSum = 0;
            while (n > 0)
            {
                char letter = char.Parse(Console.ReadLine());
                charSum += letter;
                n--;
            }
            Console.WriteLine($"The sum equals: {charSum}");
        }
    }
}
