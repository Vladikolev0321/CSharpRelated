using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();

            //string input;
            //while((input = Console.ReadLine()) != "Statistics")
            //{
            //    string[] command = input.Split("->", StringSplitOptions.RemoveEmptyEntries);

            //    if(command[0] == "Add")
            //    {
            //        string username = command[1];
            //        if(emails.ContainsKey(username))
            //        {
            //            Console.WriteLine($"{username} is already registered");
            //        }
            //        else
            //        {
            //            emails[username] = new List<string>();
            //        }
            //    }
            //    else if(command[0] == "Send")
            //    {
            //        string username = command[1];
            //        string emailToSend = command[2];

            //        emails[username].Add(emailToSend);
            //    }
            //    else
            //    {
            //        string username = command[1];
            //        if(emails.ContainsKey(username))
            //        {
            //            emails.Remove(username);
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{username} not found!");
            //        }
            //    }
            //}

            //emails = emails
            //    .OrderByDescending(kvp => kvp.Value.Count)
            //    .ThenBy(kvp => kvp.Key)
            //    .ToDictionary(a => a.Key, b => b.Value);


            //Console.WriteLine($"Users count: {emails.Count}");
            //foreach (string user in emails.Keys)
            //{
            //    Console.WriteLine(user);
            //    foreach (string email in emails[user])
            //    {
            //        Console.WriteLine($"- {email}");
            //    }
            //}

            for (int i = 10; i > 3; i -= 2)
            {
                Console.Write($"{i }");
            }


        }
    }
}
