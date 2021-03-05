using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace P09.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string command;
            while((command = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArgs = command
                                .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string trainerName = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string pokemonElement = cmdArgs[2];
                int pokemonHealth = int.Parse(cmdArgs[3]);
               
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if(!trainers.Any(t => t.Name == trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    Trainer trainer = trainers.Find(t => t.Name == trainerName);
                    trainer.Pokemons.Add(pokemon);
                }

            }
            string command2;
            while((command2 = Console.ReadLine()) != "End")
            {
                string wantedElement = command2;
                foreach (var trainer in trainers)
                {
                    if(trainer.Pokemons.Any(p => p.Element == wantedElement))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        DecreasePokemonsHealthBy10(trainer);
                        //trainer.Pokemons.Select(p => p.Health - 10);
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
            }

            trainers = trainers
                .OrderByDescending(t => t.NumberOfBadges)
                .ToList();

            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges}" +
                    $" {trainer.Pokemons.Count}");
            }



        }

        private static void DecreasePokemonsHealthBy10(Trainer trainer)
        {
            foreach (var pokemon in trainer.Pokemons)
            {
                pokemon.Health -= 10;
            }
        }
    }
}
