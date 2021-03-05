using System;
using System.Linq;

namespace P04.OpinionPoll
{
    public class Program
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

            //Person oldestPerson = family.GetOldestMember();
            ////Console.WriteLine(oldestPerson.ToString());
            //Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

            var membersSorted = family.Members
                .Where(m => m.Age > 30)
                .OrderBy(m => m.Name)
                .ToList();
            foreach (var member in membersSorted)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
