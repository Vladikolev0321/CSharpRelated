using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> citiesGold = new Dictionary<string, int>();
            Dictionary<string, int> citiesPopulation = new Dictionary<string, int>();

            string input;
            while((input = Console.ReadLine()) != "Sail")
            {
                string[] currCity = input.Split("||").ToArray();
                string cityName = currCity[0];
                int population = int.Parse(currCity[1]);
                int gold = int.Parse(currCity[2]);
                if(!citiesGold.ContainsKey(cityName))
                {
                    citiesGold[cityName] = 0;
                    citiesPopulation[cityName] = 0;
                }
                citiesGold[cityName] += gold;
                citiesPopulation[cityName] += population;

            }

            string input2;
            while((input2 = Console.ReadLine()) != "End")
            {
                string[] task = input2.Split("=>").ToArray();

                if(task[0] == "Plunder")
                {
                    string townName = task[1];
                    int peopleToKill = int.Parse(task[2]);
                    int goldToSteal = int.Parse(task[3]);

                    citiesGold[townName] -= goldToSteal;
                    citiesPopulation[townName] -= peopleToKill;

                    Console.WriteLine($"{townName} plundered! {goldToSteal} gold stolen, {peopleToKill} citizens killed.");
                    
                    if(citiesPopulation[townName] <= 0 || citiesGold[townName] <= 0)
                    {
                        citiesGold.Remove(townName);
                        citiesPopulation.Remove(townName);
                        Console.WriteLine($"{townName} has been wiped off the map!");
                    }

                }
                else if(task[0] == "Prosper")
                {
                    string townName = task[1];
                    int goldIncrease = int.Parse(task[2]);

                    if(goldIncrease < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    citiesGold[townName] += goldIncrease;
                    Console.WriteLine($"{goldIncrease} gold added to the city treasury. {townName} now has {citiesGold[townName]} gold.");
                }
            }

            citiesGold = citiesGold
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            if(citiesGold.Any())
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesGold.Count} wealthy settlements to go to:");
                foreach (string cityName in citiesGold.Keys)
                {
                    Console.WriteLine($"{cityName} -> Population: {citiesPopulation[cityName]} citizens, Gold: {citiesGold[cityName]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }
}
