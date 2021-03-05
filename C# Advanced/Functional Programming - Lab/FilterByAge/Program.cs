using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var people = new Dictionary<string,int>();
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(", ");

                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);

                people.Add(name, age);

            }

            string filterText = Console.ReadLine();
            int ageToFilter = int.Parse(Console.ReadLine());




            if (filterText == "older")
            {
                people = people
                    .Where(kvp => kvp.Value > ageToFilter)
                    .ToDictionary(x => x.Key, y => y.Value);
            }
            else if(filterText == "younger")
            {
                people = people
                    .Where(kvp => kvp.Value < ageToFilter)
                    .ToDictionary(x => x.Key, y => y.Value);
            }

        }
    }
}
