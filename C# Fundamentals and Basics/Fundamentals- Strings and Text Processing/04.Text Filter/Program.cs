using System;

namespace _04.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string wordToCensor = bannedWords[i];
                while (text.Contains(wordToCensor))
                {
                    text = text.Replace(wordToCensor, new string('*',wordToCensor.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
