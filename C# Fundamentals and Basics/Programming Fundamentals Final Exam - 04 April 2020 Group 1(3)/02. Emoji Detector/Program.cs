using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var matchesDigit = Regex.Matches(text, @"\d");

            long coolTreshold = 1;
            foreach (Match match in matchesDigit)
            {
                coolTreshold *= long.Parse(match.Value);
            }

            string emojiPattern = @"(:{2}|\*{2})(?<emoji>[A-z][a-z]{2,})\1";
            var emojiMatches = Regex.Matches(text, emojiPattern);
            int countValidEmojis = 0;

            List<string> coolEmojis = new List<string>();
            foreach (Match emoji in emojiMatches)
            {
                int coolness = 0;
                foreach (char c in emoji.Groups["emoji"].Value)
                {
                    coolness += (int)c;
                }
                if(coolness >= coolTreshold)
                {
                    coolEmojis.Add(emoji.ToString());
                }
                countValidEmojis++;
            }

            Console.WriteLine($"Cool threshold: { coolTreshold}");
            Console.WriteLine($"{countValidEmojis} emojis found in the text. The cool ones are:");
            if(coolEmojis.Count > 0)
            {
                foreach (string emoji in coolEmojis)
                {
                    Console.WriteLine(emoji);   
                }
            }
        }
    }
}
