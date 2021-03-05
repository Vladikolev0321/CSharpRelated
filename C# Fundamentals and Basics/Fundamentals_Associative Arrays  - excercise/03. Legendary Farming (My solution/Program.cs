using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming__My_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();

            Dictionary<string, int> junk = new Dictionary<string, int>();

            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            string itemObtained = "";
            bool isObtained = false;

            while (isObtained == false)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split()
                    .ToArray();
                for (int i = 0; i < inputArgs.Length; i+=2)
                {
                    int qty = int.Parse(inputArgs[i]);
                    string material = inputArgs[i + 1].ToLower();
                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += qty;
                        if(keyMaterials.Any(m => m.Value >= 250))
                        {
                            if(material == "shards")
                            {
                                itemObtained = "Shadowmourne";
                            }
                            else if( material == "fragments")
                            {
                                itemObtained = "Valanyr";
                            }
                            else
                            {
                                itemObtained = "Dragonwrath";
                            }
                            keyMaterials[material] -= 250;
                            isObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = 0;
                        }
                        junk[material] += qty;
                    }

                }

            }
            Console.WriteLine($"{itemObtained} obtained!");

            keyMaterials = keyMaterials
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var trash in junk.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{trash.Key}: {trash.Value}");
            }
        }
    }
}
