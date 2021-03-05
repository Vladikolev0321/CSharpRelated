using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Engine
    {
        private const string END_OF_INPUT_COMMAND = "Beast!";
        private readonly List<Animal> animals;
        public Engine ()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string type = Console.ReadLine();
            while (type != END_OF_INPUT_COMMAND)
            {
                string[] animalArgs = Console.ReadLine()
                    .Split();

                Animal animal;

                try
                {
                     animal = GetAnimal(type, animalArgs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    type = Console.ReadLine();
                    continue;

                    
                }


                this.animals.Add(animal);

                type = Console.ReadLine();
            }

            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal GetAnimal(string type,string[] animalArgs)
        {
            string name = animalArgs[0];
            int age = int.Parse(animalArgs[1]);
            string gender = GetGender(animalArgs);

            Animal animal = null;

            if (type == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (type == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else if (type == "Kitten")
            {
                animal = new Kitten(name, age);
            }
            else if (type == "Tomcat")
            {
                animal = new Tomcat(name, age, gender);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }
            return animal;
        }

        private  string GetGender(string[] animalArgs)
        {
            string gender = null;

            if (animalArgs.Length >= 3)
            {
                gender = animalArgs[2];
            }

            return gender;
        }
    }
}
