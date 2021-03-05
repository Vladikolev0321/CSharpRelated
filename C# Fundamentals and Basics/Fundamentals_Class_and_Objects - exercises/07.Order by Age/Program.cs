using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }
                string[] tokens = input.Split();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person(name, id, age);

                people.Add(person);
            }
            foreach (Person person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine(person.ToString());
            }
            
        }
    }
    class Person
    {
        public Person(string name, string id , int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
