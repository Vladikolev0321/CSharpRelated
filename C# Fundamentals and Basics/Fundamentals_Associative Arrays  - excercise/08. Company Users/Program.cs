using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string inp = Console.ReadLine();
                if(inp == "End")
                {
                    break;
                }
                string[] command = inp.Split(" -> ").ToArray();

                string companyName = command[0];
                string id = command[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new List<string>();
                }
                if (!companies[companyName].Contains(id))
                {
                    companies[companyName].Add(id);
                }

            }

            foreach (var kvp in companies.OrderBy(c => c.Key))
            {
                Console.WriteLine(kvp.Key);
                foreach (var id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
