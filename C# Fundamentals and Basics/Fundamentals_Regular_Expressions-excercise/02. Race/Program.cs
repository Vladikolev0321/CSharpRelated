using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();

            Dictionary<string, int> racers = new Dictionary<string, int>();

            foreach (string name in names)
            {
                if (!racers.ContainsKey(name))
                {
                    racers[name] = 0;
                }
            }


            while (true)
            {
                string input = Console.ReadLine();
                int distance = 0;
                if (input == "end of race")
                {
                    break;
                }

                string wordPattern = @"[A-Za-z]";
                string name = "";

                var matches = Regex.Matches(input, wordPattern);

                foreach (Match match in matches)
                {
                    name += match.Value;
                }

                if (racers.ContainsKey(name))
                {
                    var matchesDistance = Regex.Matches(input, @"[0-9]");

                    foreach (Match match in matchesDistance)
                    {
                        distance += int.Parse(match.Value);
                    }

                    racers[name] += distance;
                }
            }

            racers = racers
                .OrderByDescending(kvp => kvp.Value)
                .Take(3)
                .ToDictionary(a => a.Key, b => b.Value);

            int counter = 1;
            foreach (var kvp in racers)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {kvp.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {kvp.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {kvp.Key}");
                }
                counter++;
            }
            
        }
    }
}
