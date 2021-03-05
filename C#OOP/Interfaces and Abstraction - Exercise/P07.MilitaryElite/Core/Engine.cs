using P07.MilitaryElite.Contracts;
using P07.MilitaryElite.Exceptions;
using P07.MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07.MilitaryElite.Core
{
    public class Engine
    {
        private ICollection<ISoldier> soldiers;

        public Engine()
        {
            this.soldiers = new List<ISoldier>();
        }
        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command
                    .Split()
                    .ToArray();

                string soldierType = cmdArgs[0];
                int  id = int.Parse(cmdArgs[1]);
                string firstName = cmdArgs[2];
                string lastName = cmdArgs[3];

                ISoldier soldier = null;
                if (soldierType == "Private")
                {
                    soldier = AddPrivate(cmdArgs, id, firstName, lastName);

                }
                else if (soldierType == "LieutenantGeneral")
                {
                    soldier = AddGeneral(cmdArgs, id, firstName, lastName);
                }
                else if (soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);
                    string corps = cmdArgs[5];

                    try
                    {
                        IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                        string[] repairArgs = cmdArgs
                            .Skip(6)
                            .ToArray();

                        for (int i = 0; i < repairArgs.Length; i += 2)
                        {
                            string partName = repairArgs[i];
                            int hoursWorked = int.Parse(repairArgs[i + 1]);

                            IRepair repair = new Repair(partName, hoursWorked);

                            engineer.AddRepair(repair);
                        }
                        soldier = engineer;

                    }
                    catch (InvalidCorpsException )
                    {
                        continue;                       
                    }
                }
                else if (soldierType == "Commando")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);
                    string corps = cmdArgs[5];

                    try
                    {
                        ICommando commando = new Commando(id, firstName, lastName, salary, corps);

                        string[] missionArgs = cmdArgs
                            .Skip(6)
                            .ToArray();

                        for (int i = 0; i < missionArgs.Length; i+=2)
                        {
                            try
                            {
                                GetCommando(commando, missionArgs, i);

                            }
                            catch (InvalidMissionStateException)
                            {

                                continue;
                            }
                            
                        }
                        soldier = commando;
                    }
                    catch (InvalidCorpsException)
                    {

                        continue;
                    }
                }
                else if(soldierType == "Spy")
                {
                    int codeNumber = int.Parse(cmdArgs[4]);

                    soldier = new Spy(id, firstName, lastName, codeNumber);
                }

                if(soldier != null)
                {
                    soldiers.Add(soldier);
                }
            }

            foreach (var soldier in this.soldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private static void GetCommando(ICommando commando, string[] missionArgs, int i)
        {
            string missionCodeName = missionArgs[i];
            string missionState = missionArgs[i + 1];

            IMission mission = new Mission(missionCodeName, missionState);

            commando.AddMission(mission);
        }

        private ISoldier AddGeneral(string[] cmdArgs, int id, string firstName, string lastName)
        {
            ISoldier soldier;
            decimal salary = decimal.Parse(cmdArgs[4]);
            ILieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);

            foreach (string pid in cmdArgs.Skip(5))
            {
                ISoldier privateToAdd = this.soldiers
                    .First(s => s.Id == int.Parse(pid));

                general.AddPrivate(privateToAdd);
            }
            soldier = general;
            return soldier;
        }

        private static ISoldier AddPrivate(string[] cmdArgs, int id, string firstName, string lastName)
        {
            ISoldier soldier;
            decimal salary = decimal.Parse(cmdArgs[4]);
            soldier = new Private(id, firstName, lastName, salary);
            return soldier;
        }
    }
}
