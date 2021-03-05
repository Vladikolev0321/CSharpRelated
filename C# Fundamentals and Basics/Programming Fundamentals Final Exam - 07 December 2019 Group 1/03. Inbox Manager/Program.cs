using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Statistics")
                {
                    break;
                }
                string[] command = input
                    .Split("->");

                string user = command[1];
                switch (command[0])
                {
                    
                    case "Add":
                        
                        if (!users.ContainsKey(user))
                        {
                            users[user] = new List<string>();
                        }
                        else
                        {
                            Console.WriteLine($"{user} is already registered");
                        }
                        break;
                    case "Send":
                        string email = command[2];
                        if (users.ContainsKey(user))
                        {
                            users[user].Add(email);
                        }
                        break;
                    case "Delete":
                        if (users.ContainsKey(user))
                        {
                            users.Remove(user);
                        }
                        else
                        {
                            Console.WriteLine($"{user} not found!");
                        }
                        break;                      
                }
            
            }
            users = users
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);


            Console.WriteLine($"Users count: {users.Count}");
            foreach (var kvp in users)
            {
                Console.WriteLine(kvp.Key);
                foreach (string email in kvp.Value)
                {
                    Console.WriteLine($"- {email}");
                }
            }

        }
    }
}
