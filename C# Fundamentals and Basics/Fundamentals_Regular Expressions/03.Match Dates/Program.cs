using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regex = @"(\d{2})([-\/.])([A-Z][a-z]{2})\2(\d{4})";

            var date = Regex.Matches(input, regex);

            foreach (Match match in date)
            {
                Console.WriteLine($"Day: {match.Groups[1]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");
            }

        }
    }
}
