using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = cmdArgs[0];
                string[] clothesWithThisColor = cmdArgs[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                foreach (var cloth in clothesWithThisColor)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color][cloth] = 0;
                    }
                    wardrobe[color][cloth]++;
                }

            }
            string[] itemSearchedArgs = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            foreach (var kvp in wardrobe)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var cloth in kvp.Value)
                {
                    if(kvp.Key == itemSearchedArgs[0] && cloth.Key == itemSearchedArgs[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }

                }
            }
        }
    }
}
