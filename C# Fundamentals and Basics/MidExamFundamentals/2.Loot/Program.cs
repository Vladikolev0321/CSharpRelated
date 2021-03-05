using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Loot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loot = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(command[0] == "Loot")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        string itemToAdd = command[i];
                        if (!loot.Contains(itemToAdd))
                        {
                            loot.Insert(0, itemToAdd);
                        }
                    }
                }
                else if(command[0] == "Drop")
                {
                    int index = int.Parse(command[1]);
                    if(index >= 0 && index < loot.Count)
                    {
                        string itemToRemove = loot[index];
                        loot.RemoveAt(index);
                        loot.Add(itemToRemove);
                    }
                }
                else if(command[0] == "Steal")
                {
                    int count = int.Parse(command[1]);
                    List<string> removedItems = new List<string>();
                    if(count >= loot.Count)
                    {
                        //loot.RemoveRange(0, loot.Count);
                        int length = loot.Count;
                        for (int i = 0; i < length; i++)
                        {
                            string item = loot[0];
                            removedItems.Add(item);
                            loot.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            string item = loot[loot.Count - count + i];
                            removedItems.Add(item);
                            loot.RemoveAt(loot.Count - count + i);

                        }
                        //loot.RemoveRange(loot.Count - count, count);
                    }
                        Console.WriteLine(string.Join(", ", removedItems));
                }
            }
            if(loot.Count > 0)
            {
                double sumItemsLength = loot.Sum(i => i.Length);
                Console.WriteLine($"Average treasure gain: {(sumItemsLength/loot.Count):F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }

        }
    }
}
