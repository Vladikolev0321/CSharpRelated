using System;

namespace P03.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] personArgs = Console.ReadLine().Split();

                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();
            //Console.WriteLine(oldestPerson.ToString());
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
