using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            Dictionary<int, string> itemsTable = new Dictionary<int, string>()
            {
                {25, "Bread" },
                {50, "Cake" },
                {75, "Pastry" },
                {100, "Fruit Pie"}
            };

            Dictionary<string, int> cookedItems = new Dictionary<string, int>()
            {
                {"Bread", 0 },
                {"Cake", 0 },
                {"Pastry", 0 },
                {"Fruit Pie", 0 }
            };

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int sum = liquids.Peek() + ingredients.Peek();
                if(itemsTable.ContainsKey(sum))
                {
                    string itemName = itemsTable[sum];
                    cookedItems[itemName]++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    int popped = ingredients.Pop();
                    ingredients.Push(popped + 3);
                }
            }

            if(cookedItems.All(kvp => kvp.Value >= 1))
            {
                Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if(liquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            cookedItems = cookedItems.OrderBy(kvp => kvp.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in cookedItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
