using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialBitcoins = 0;
            string[] dungeons = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();

            int roomCount = 0;
            for(int i = 0; i < dungeons.Length; i++)
            {
                roomCount++;
                string[] currDungeon = dungeons[i].Split().ToArray();
                string command = currDungeon[0];

                if(command == "potion")
                {
                    int amount = int.Parse(currDungeon[1]);
                    if(initialHealth < 100)
                    {
                        if(initialHealth + amount > 100)
                        {
                            Console.WriteLine($"You healed for {100 - initialHealth} hp.");
                            initialHealth = 100;
                        }
                        else
                        {
                            initialHealth += amount;
                            Console.WriteLine($"You healed for {amount} hp.");
                        }
                    }
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else if(command == "chest")
                {
                    int amount = int.Parse(currDungeon[1]);
                    initialBitcoins += amount;

                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    int monsterAttack = int.Parse(currDungeon[1]);
                    initialHealth -= monsterAttack;

                    if(initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {roomCount}");
                        return;
                    }
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {initialBitcoins}");
            Console.WriteLine($"Health: {initialHealth}");
        }
    }
}
