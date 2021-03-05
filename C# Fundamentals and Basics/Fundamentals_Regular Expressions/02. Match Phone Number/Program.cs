using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string regex = @"\+359(-| )2\1\d{3}\1\d{4}\b";

            var phoneMatches = Regex.Matches(text, regex);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));


            //foreach (Match match in phoneMatches)
            //{
            //    Console.Write($"{match.Value} ");
            //}

        }
    }
}
