using _05._Birthday_Celebrations.Models;
using P05.BirthdayCelebrations.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.BirthdayCelebrations
{
    public class Engine
    {
        public void Run()
        {
           // List<string> allIds = new List<string>();
         //   List<IIdentifiable> citizens = new List<IIdentifiable>();
           // List<IIdentifiable> robots = new List<IIdentifiable>();
            
            List<IIdentifiable> robotsAndCitizens = new List<IIdentifiable>();
            List<IBirthable> birthables = new List<IBirthable>();


            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command
                    .Split()
                    .ToArray();

                if(commandArgs.Length == 5)
                {
                    string name = commandArgs[1];
                    int age = int.Parse(commandArgs[2]);
                    string id = commandArgs[3];
                    string birthdate = commandArgs[4];

                    Citizen citizen = new Citizen(name, age, id,birthdate);
                    //  citizens.Add(citizen);
                    robotsAndCitizens.Add(citizen);
                    birthables.Add(citizen);
                }
                else if(commandArgs[0] == "Robot")
                {
                    string model = commandArgs[1];
                    string id = commandArgs[2];

                    Robot robot = new Robot(model, id);
                    //robots.Add(robot);
                    robotsAndCitizens.Add(robot);
                    

                }
                else
                {
                    string name = commandArgs[1];
                    string birthdate = commandArgs[2];

                    Pet pet = new Pet(name, birthdate);

                    birthables.Add(pet);
                }

            }
            // string lastDigitFakeId = Console.ReadLine();

            // PrintFakeId(robotsAndCitizens, lastDigitFakeId);

            string lastDigitYear = Console.ReadLine();

            PrintListLastDigitThisYear(birthables, lastDigitYear);
           

        }
        private void PrintListLastDigitThisYear(List<IBirthable> birthables, string lastDigitYear)
        {
            foreach (IBirthable birthable in birthables)
            {
                string currBirthDate = birthable.GetBirth();
                if (currBirthDate.EndsWith(lastDigitYear))
                {
                    Console.WriteLine(currBirthDate);
                }
            }
        }



        private void PrintFakeId(List<IIdentifiable> robotsAndCitizens , string lastDigitFakeId)
        {
            foreach (IIdentifiable citizenOrRobot in robotsAndCitizens)
            {
                string currId = citizenOrRobot.GetId();
                if (currId.EndsWith(lastDigitFakeId))
                {
                    Console.WriteLine(currId);
                }
            }
        }
    }
}
