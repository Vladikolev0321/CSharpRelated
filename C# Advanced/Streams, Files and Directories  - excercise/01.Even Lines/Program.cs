using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace _01.Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charactersToReplace = { '-', ',', '.', '!', '?' };

            StreamReader streamReader = new StreamReader("text.txt");

            int counter = 0;
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();

                if(line == null)
                {
                    break;
                }

                if(counter % 2 == 0)
                {
                    line = ReplaceAll(charactersToReplace, '@', line);

                    line = ReverseWordsInText(line);

                    Console.WriteLine(line);

                }

                counter++;
            }
        }
        static string ReplaceAll(char[] replace , char replacement, string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                char currSymbol = str[i];

                if (replace.Contains(currSymbol))
                {
                    sb.Append(replacement);
                }
                else
                {
                    sb.Append(currSymbol);
                }
            }
            return sb.ToString().TrimEnd();
        }
        static string ReverseWordsInText(string str)
        {
            StringBuilder sb = new StringBuilder();

            string[] words = str
                .Split()
                .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[words.Length - i - 1]);
                sb.Append(' ');
            }
            return sb.ToString().TrimEnd();
        }
    }
}
