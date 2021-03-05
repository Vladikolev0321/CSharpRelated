using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();

            while (true)
            {
                string inp = Console.ReadLine();
                if (inp == "Lumpawaroo")
                {
                    break;
                }
                string[] inputArgs = inp
                    .Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (inp.Contains("|"))
                {
                    string side = inputArgs[0];
                    string user = inputArgs[1];

                    AddUser(book, side, user);
                }
                else if (inp.Contains("->"))
                {
                    string user = inputArgs[0];
                    string side = inputArgs[1];

                    MoveUserToSide(book, user, side);

                }


            }
            PrintOutput(book);

        }

        private static void PrintOutput(Dictionary<string, List<string>> book)
        {
            Dictionary<string, List<string>> orderedBook = book
                            .Where(kvp => kvp.Value.Count > 0)
                            .OrderByDescending(kvp => kvp.Value.Count)
                            .ThenBy(kvp => kvp.Key)
                            .ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in orderedBook)
            {
                string currentSide = kvp.Key;
                List<string> currentSideUsers = kvp.Value
                    .OrderBy(x => x)
                    .ToList();
                Console.WriteLine($"Side: {currentSide}, Members: {currentSideUsers.Count}");
                foreach (var name in currentSideUsers)
                {
                    Console.WriteLine($"! {name}");
                }
            }
        }

        static void AddUser(Dictionary<string, List<string>> book, string side, string user)
        {
            if (!book.ContainsKey(side))
            {
                book[side] = new List<string>();
            }
            if (!book.Values.Any(l => l.Contains(user))) /////To try without Any just Contains
            {
                book[side].Add(user);
            }
        }

        static void MoveUserToSide(Dictionary<string, List<string>> book, string user, string side)
        {
            foreach (var kvp in book)
            {
                if (kvp.Value.Contains(user))
                {
                    kvp.Value.Remove(user);
                }
                
            }
            if (!book.ContainsKey(side))
                {
                    book[side] = new List<string>();
                }

                book[side].Add(user);
                Console.WriteLine($"{user} joins the {side} side!");
        }
    }
}
