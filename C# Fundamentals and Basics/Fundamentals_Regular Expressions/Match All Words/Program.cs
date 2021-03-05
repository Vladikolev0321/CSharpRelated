using System;
using System.Text.RegularExpressions;

namespace Match_All_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\d{2}(\W)\w{3}\1[0-9]{4}");



            MatchCollection matches= regex.Matches(@"30.Dec.1994 30/Dec/1994 33-Jul-1995.");
            

            bool matches2 = regex.IsMatch(@"30.Dec.1994 30/Dec/1994 33-Jul-1995.");
            Console.WriteLine(matches2);
            Console.WriteLine(matches.Count);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
