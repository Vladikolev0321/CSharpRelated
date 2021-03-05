using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string command1;
            while((command1 = Console.ReadLine()) != "end of contests")
            {
                string[] cmdArgs = command1
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contestName = cmdArgs[0];
                string pass = cmdArgs[1];

                contests[contestName] = pass;
            }

            Dictionary<string, Dictionary<string, int>> users = new
                Dictionary<string, Dictionary<string, int>>();

            string command2;
            while ((command2 = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArgs = command2
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string contestName = cmdArgs[0];
                string pass = cmdArgs[1];
                string username = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);
                
                if(contests.ContainsKey(contestName) && contests[contestName] == pass)
                {
                    if (!users.ContainsKey(username))
                    {
                        users[username] = new Dictionary<string, int>();
                    }
                    if(users[username].ContainsKey(contestName) 
                        && users[username][contestName] < points)
                    {
                        users[username][contestName] = points;
                    }
                    else if(!users[username].ContainsKey(contestName))
                    {
                        users[username][contestName] = points;
                    }
                }
            }

            
            ///Finding best user
            var bestUsers = users
                .OrderByDescending(kvp => kvp.Value.Values.Sum())
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"Best candidate is {bestUsers.First().Key} with total " +
                $"{bestUsers.First().Value.Values.Sum()} points.");

            //////Ordering the users
            users = users
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Ranking:");
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}");
                foreach (var contest in user.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }


        }
    }
}
