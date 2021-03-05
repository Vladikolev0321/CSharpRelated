using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(VowelCount(str));
        }
        static int VowelCount(string str)
        {
            string newStr = str.ToLower();
            int counter = 0;
            foreach (char letter in newStr)
            {
                if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
