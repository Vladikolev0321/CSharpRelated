using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();

            Dictionary<string, int> countLanguages = new Dictionary<string, int>();

            while (true)
            {
                string inp = Console.ReadLine();
                if (inp == "exam finished")
                {
                    break;
                }
                string[] command = inp.Split("-");

                if(command[1] == "banned")
                {
                    string userName = command[0];
                    results.Remove(userName);
                }
                else
                {
                    string userName = command[0];
                    string language = command[1];
                    int points = int.Parse(command[2]);
                    if (!countLanguages.ContainsKey(language))
                    {
                        countLanguages[language] = 0;
                    }
                    if (!results.ContainsKey(userName))
                    {
                        results[userName] = 0;
                    }
                    if(points > results[userName])
                    {
                        results[userName] = points;
                    }                   
                    countLanguages[language]++;

                }
            }

            var sortedResults = results
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary( a => a.Key, b => b.Value);

            countLanguages = countLanguages
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine("Results:");
            foreach (var kvp in sortedResults)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");               
            }
            Console.WriteLine("Submissions:");
            foreach (var lang in countLanguages)
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }
        }
    }
}
