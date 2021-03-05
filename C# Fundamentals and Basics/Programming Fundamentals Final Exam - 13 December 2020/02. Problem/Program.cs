using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"(.+)>(?<first>\d{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^\n]{3})<(\1)";

            for (int i = 0; i < n; i++)
            {
                string currPass = Console.ReadLine();
                if(Regex.IsMatch(currPass, pattern))
                {
                    Match match = Regex.Match(currPass, pattern);
                    StringBuilder sb = new StringBuilder();

                    sb.Append(match.Groups["first"].Value);
                    sb.Append(match.Groups["second"].Value);
                    sb.Append(match.Groups["third"].Value);
                    sb.Append(match.Groups["fourth"].Value);

                    Console.WriteLine($"Password: {sb.ToString()}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
