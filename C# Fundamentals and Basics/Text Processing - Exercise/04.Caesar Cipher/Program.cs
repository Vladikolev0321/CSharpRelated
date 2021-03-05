using System;
using System.Text;

namespace _04.Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                letter = (char)(letter + 3);
                sb.Append(letter);
            }
            Console.WriteLine(sb);
        }
    }
}
