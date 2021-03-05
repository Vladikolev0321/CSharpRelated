using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> citiesPopulation = new Dictionary<string, int>();
            Dictionary<string, int> citiesGold = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Sail")
                {
                    break;
                }
                string[] command = input.Split("||");
                string city = command[0];
                int population = int.Parse(command[1]);
                int gold = int.Parse(command[2]);

                if (!citiesPopulation.ContainsKey(city))
                {
                    citiesPopulation[city] = 0;
                    citiesGold[city] = 0;
                }
                citiesPopulation[city] += population;
                citiesGold[city] += gold;
            }

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }
                string[] command = input.Split("=>");
                if(command[0] == "Plunder")
                {
                    string city = command[1];
                    int peopleKilled = int.Parse(command[2]);
                    int goldStolen = int.Parse(command[3]);

                    Console.WriteLine($"{city} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                    
                    if(citiesGold[city]-goldStolen > 0 && citiesPopulation[city] - peopleKilled > 0)
                    {
                        citiesGold[city] -= goldStolen;
                        citiesPopulation[city] -= peopleKilled;
                    }
                    else
                    {
                        citiesPopulation.Remove(city);
                        citiesGold.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }

                }
                else if(command[0] == "Prosper")
                {
                    string city = command[1];
                    int goldIncome = int.Parse(command[2]);
                    if(goldIncome < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        citiesGold[city] += goldIncome;
                        Console.WriteLine($"{goldIncome} gold added to the city treasury. {city} now has {citiesGold[city]} gold.");
                    }
                }
            }
            citiesGold = citiesGold
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);
            if(citiesGold.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesGold.Count} wealthy settlements to go to:");
                foreach (string city in citiesGold.Keys)
                {
                    Console.WriteLine($"{city} -> Population: {citiesPopulation[city]} citizens, Gold: {citiesGold[city]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}
