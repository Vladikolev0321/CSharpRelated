using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while((input = Console.ReadLine()) != "Craft!")
            {
                string[] command = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(command[0] == "Collect")
                {
                    string itemToAdd = command[1];
                    if(!inventory.Any(item => item == itemToAdd))
                    {
                        inventory.Add(itemToAdd);
                    }
                }
                else if(command[0] == "Drop")
                {
                    string itemToRemove = command[1];
                    if (inventory.Any(item => item == itemToRemove))
                    {
                        inventory.Remove(itemToRemove);
                    }
                }
                else if(command[0] == "Combine Items")
                {
                    string[] items = command[1].Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string oldItem = items[0];
                    string newItem = items[1];
                    int indexOfOldItem;
                    if((indexOfOldItem = inventory.FindIndex(item => item == oldItem)) != -1)
                    {
                        inventory.Insert(indexOfOldItem + 1, newItem);
                    }
                }
                else
                {
                    string itemToRenew = command[1];
                    if (inventory.Any(item => item == itemToRenew))
                    {
                        inventory.Remove(itemToRenew);
                        inventory.Add(itemToRenew);
                    }

                }
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
