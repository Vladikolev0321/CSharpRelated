using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"[U][$](?<userName>[A-Z][a-z]{2,})[U][$]P@\$(?<password>[A-Za-z]{5,}\d+)P@\$";
            int countSuccesfullRegis = 0;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups["userName"].Value}, Password: {match.Groups["password"]}");
                    countSuccesfullRegis++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password"); 
                }
            }

            Console.WriteLine($"Successful registrations: {countSuccesfullRegis}");
        }
    }
}
