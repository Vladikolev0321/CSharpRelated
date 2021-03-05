using P04._BorderControl.Contracts;
using P04._BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04._BorderControl.Core
{
    public class Engine
    {
        public void Run()
        {
           // List<string> allIds = new List<string>();
         //   List<IIdentifiable> citizens = new List<IIdentifiable>();
           // List<IIdentifiable> robots = new List<IIdentifiable>();
            
            List<IIdentifiable> robotsAndCitizens = new List<IIdentifiable>();


            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command
                    .Split()
                    .ToArray();

                if(commandArgs.Length == 3)
                {
                    string name = commandArgs[0];
                    int age = int.Parse(commandArgs[1]);
                    string id = commandArgs[2];

                    Citizen citizen = new Citizen(name, age, id);
                    //  citizens.Add(citizen);
                    robotsAndCitizens.Add(citizen);
                }
                else if(commandArgs.Length == 2)
                {
                    string model = commandArgs[0];
                    string id = commandArgs[1];

                    Robot robot = new Robot(model, id);
                    //robots.Add(robot);
                    robotsAndCitizens.Add(robot);

                }

            }
            string lastDigitFakeId = Console.ReadLine();

            PrintFakeId(robotsAndCitizens, lastDigitFakeId);
           

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
