using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;
            while((input = Console.ReadLine()) != "END")
            {
                string[] personInfo = input
                    .Split()
                    .ToArray();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                string town = personInfo[2];

                Person person = new Person(name, age, town);

                people.Add(person);
            }

            int n = int.Parse(Console.ReadLine());

            Person personTOCompare = people[n-1];


            //people.Remove(personTOCompare);

            int matchesCount = 0;

            foreach (var person in people)
            {
                if(personTOCompare.CompareTo(person) == 0)
                {
                    matchesCount++;
                }
            }

            if(matchesCount <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int notmatchesCount = people.Count - matchesCount;
                Console.WriteLine($"{matchesCount} {notmatchesCount} {people.Count}");
            }
        }
    }
}
