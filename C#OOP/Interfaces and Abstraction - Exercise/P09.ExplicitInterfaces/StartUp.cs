using P09.ExplicitInterfaces.Contracts;
using P09.ExplicitInterfaces.Models;
using System;
using System.Linq;

namespace P09.ExplicitInterfaces
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split()
                    .ToArray();

                string name = cmdArgs[0];
                string country = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);

                Citizen citizen = new Citizen(name, country, age);
                IPerson person = citizen;
                IResident resident = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

            }
        }
    }
}
