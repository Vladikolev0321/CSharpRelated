using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(
                Console.ReadLine()
                .Split(", ")
                .Select(int.Parse).ToList());

            Stack<int> bombCasing = new Stack<int>(
                Console.ReadLine()
                .Split(", ")
                .Select(int.Parse).ToList());

            Dictionary<int, string> typeBombs = new Dictionary<int, string>()
            {
                { 40, "Datura Bombs" },
                { 60, "Cherry Bombs" },
                { 120, "Smoke Decoy Bombs"}

            };

            Dictionary<string, int> bombPouch = new Dictionary<string, int>()
            {
                { "Datura Bombs", 0 },
                { "Cherry Bombs", 0 },
                { "Smoke Decoy Bombs", 0}
            };

            while(bombEffects.Any() && bombCasing.Any() && bombPouch.Any(kvp => kvp.Value < 3))
            {
                int sum = bombEffects.Peek() + bombCasing.Peek();
                
                if(typeBombs.Any(kvp => kvp.Key == sum))
                {
                    string newBombName = typeBombs[sum];
                    bombPouch[newBombName]++;
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                }
                else
                {
                    int prevBombCasing = bombCasing.Pop();
                    bombCasing.Push(prevBombCasing - 5);
                }
            }

            if(bombPouch.All(kvp => kvp.Value >= 3))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if(bombEffects.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (bombCasing.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach(var kvp in bombPouch.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
