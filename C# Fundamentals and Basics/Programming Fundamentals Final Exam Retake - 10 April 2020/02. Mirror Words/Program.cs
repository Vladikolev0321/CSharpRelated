using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //string hiddenPattern = @"((#|@)(?<word1>[A-Za-z]{3,})(\2))((\2)(?<word2>[A-Za-z]{3,})(\4))";
            string hiddenPattern = @"(@|#)(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";

            List<string> mirrorWords = new List<string>();
            var matches = Regex.Matches(text, hiddenPattern);
            if(matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                //Dictionary<string, string> mirrorWords = new Dictionary<string, string>();
                

                foreach (Match match in matches)
                {
                    string str1 = match.Groups["first"].Value;
                    string str2 = match.Groups["second"].Value;

                    char[] str2Arr = str2.ToCharArray();
                    Array.Reverse(str2Arr);
                    string str2InStringReversed = new string(str2Arr);

                    if(str1 == str2InStringReversed)
                    {
                        string mirrorWord = str1 + " <=> " + str2;
                        mirrorWords.Add(mirrorWord);
                    }
                }
                
            }

            if (mirrorWords.Count != 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", mirrorWords));
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }

        }
    }
}
