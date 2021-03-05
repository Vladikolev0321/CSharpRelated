using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffectsInfo = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[] bombCasingInfo = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> bombEffects = new Queue<int>(bombEffectsInfo);
            Stack<int> bombCasings = new Stack<int>(bombCasingInfo);

            var bombs = new Dictionary<int, string>()
            {
                { 40,"Datura Bombs" }
                ,{60 ,"Cherry Bombs"}
                ,{120,"Smoke Decoy Bombs"}
            };

            Dictionary<string, int> madeBombsCount = new Dictionary<string, int>() 
            {
                { "Datura Bombs",0 }
                ,{"Cherry Bombs",0 }
                ,{"Smoke Decoy Bombs",0}
            };

            while(bombEffects.Any() && bombCasings.Any() && madeBombsCount.Any(kvp => kvp.Value < 3))
            {
                int currBombEffect = bombEffects.Peek();
                int currBombCasing = bombCasings.Peek();
                if(bombs.Any(kvp => kvp.Key == currBombEffect + currBombCasing))
                {
                    string bombMadeName = bombs[currBombCasing + currBombEffect];

                    madeBombsCount[bombMadeName]++;

                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    bombCasings.Push(bombCasings.Pop() - 5);
                }
            }

            if(madeBombsCount.All(kvp => kvp.Value >= 3))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasings.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            madeBombsCount = madeBombsCount
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in madeBombsCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
