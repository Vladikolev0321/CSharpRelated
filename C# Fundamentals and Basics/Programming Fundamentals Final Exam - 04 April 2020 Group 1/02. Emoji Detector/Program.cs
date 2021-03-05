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

            string digitPattern = @"\d";
            long coolTreshold = 1;
            var matchesDigit = Regex.Matches(text, digitPattern);
            foreach (Match match in matchesDigit)
            {
                coolTreshold *= long.Parse(match.Value);
            }

            string emojiPattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            int emojiCount = 0;
            var matchedEmojis = Regex.Matches(text, emojiPattern);

            List<string> coolEmojis = new List<string>();
            foreach (Match match in matchedEmojis)
            {
                int coolness = 0;
                foreach (char c in match.Groups["emoji"].Value)
                {
                    coolness += (int)c;
                }
                if(coolness >= coolTreshold)
                {
                    coolEmojis.Add(match.ToString());
                }
                emojiCount++;
                ////Remove from text
            }
                Console.WriteLine($"Cool threshold: {coolTreshold}");
                Console.WriteLine($"{emojiCount} emojis found in the text. The cool ones are:");
            if (coolEmojis.Count > 0)
            {
                
                foreach (string emoji in coolEmojis)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}
