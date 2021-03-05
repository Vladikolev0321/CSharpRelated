using P04.WildFarm.Contracts;
using P04.WildFarm.Exceptions;
using P04.WildFarm.Factories;
using P04.WildFarm.Models;
using P04.WildFarm.Models.Animals.Birds;
using P04.WildFarm.Models.Animals.Mammals;
using P04.WildFarm.Models.Animals.Mammals.Felines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04.WildFarm.Core
{
    public class Engine 
    {
        private ICollection<IAnimal> animals;
        private FoodFactory foodFactory;
        public Engine()
        {
            this.animals = new List<IAnimal>();
            this.foodFactory = new FoodFactory();
        }
        public void Run()
        {
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] animalArgs = command
                    .Split()
                    .ToArray();

                string[] foodArgs = Console.ReadLine()
                    .Split()
                    .ToArray();


                IAnimal animal = ProduceAnimal(animalArgs);
                IFood food = foodFactory.ProduceFood(foodArgs[0], int.Parse(foodArgs[1]));

                animal.ProduceSound();
                try
                {
                    animal.Feed(food);
                }
                catch (UneatableFoodException ufe)
                {
                    Console.WriteLine(ufe.Message);
                }
                animals.Add(animal);
            }

            foreach (IAnimal animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static IAnimal ProduceAnimal(string[] animalArgs)
        {
            IAnimal animal = null;

            string animalType = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);

            if (animalType == "Owl")
            {
                double wingSize = double.Parse(animalArgs[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (animalType == "Hen")
            {
                double wingSize = double.Parse(animalArgs[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else
            {
                string livingRegion = animalArgs[3];
                if (animalType == "Dog")
                {
                    animal = new Dog(name, weight, livingRegion);
                }
                else if (animalType == "Mouse")
                {
                    animal = new Mouse(name, weight, livingRegion);
                }
                else
                {
                    string breed = animalArgs[4];
                    if (animalType == "Cat")
                    {
                        animal = new Cat(name, weight, livingRegion, breed);
                    }
                    else if (animalType == "Tiger")
                    {
                        animal = new Tiger(name, weight, livingRegion, breed);
                    }
                }
            }

            return animal;
        }
    }
}
