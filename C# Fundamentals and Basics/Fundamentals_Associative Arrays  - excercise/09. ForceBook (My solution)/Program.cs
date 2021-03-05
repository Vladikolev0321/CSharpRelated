using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook__My_solution_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            while (true)
            {
                string inp = Console.ReadLine();
                if(inp == "Lumpawaroo")
                {
                    break;
                }
                string[] inputArgs = inp
                    .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                if(inp.Contains("|"))
                {
                    string side = inputArgs[0];
                    string user = inputArgs[1];
                    AddUser(book, side, user);
                }
                else
                {
                    string side = inputArgs[1];
                    string user = inputArgs[0];
                    MoveUser(book, side, user);
                }
            }

            book = book
                .Where(kvp => kvp.Value.Count>0)
               .OrderByDescending(kvp => kvp.Value.Count)
               .ThenBy(kvp => kvp.Key)
               .ToDictionary(a => a.Key, b => b.Value);

            foreach (var side in book)
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(u =>u))
                {
                    Console.WriteLine($"! {user}");
                }
            }
            
        }

        private static void MoveUser(Dictionary<string, List<string>> book, string side, string user)
        {
            if (book.Any(b => b.Value.Contains(user)))
            {
                foreach (var kvp in book)
                {
                    if (kvp.Value.Contains(user))
                    {
                        kvp.Value.Remove(user);
                    }
                }
            }
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();
            }

            book[side].Add(user);
            Console.WriteLine($"{user} joins the {side} side!");
        }

        private static void AddUser(Dictionary<string, List<string>> book, string side, string user)
        {
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();
            }
            if (!book.Any(b => b.Value.Contains(user)))
            {
                book[side].Add(user);
            }
        }
    }
}
