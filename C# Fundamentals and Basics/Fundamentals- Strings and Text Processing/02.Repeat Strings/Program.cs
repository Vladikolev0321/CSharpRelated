using System;

namespace _02.Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    result += word;
                }
                //Console.Write(new string(word.ToCharArray(),0, word.Length));
            }
            Console.WriteLine(result);
        }
    }
}
