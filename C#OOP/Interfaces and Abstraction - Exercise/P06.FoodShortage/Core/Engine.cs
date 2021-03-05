using P06.FoodShortage.Contracts;
using P06.FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.FoodShortage
{
    public class Engine
    {
        public void Run()
        {
            // List<string> allIds = new List<string>();
            //   List<IIdentifiable> citizens = new List<IIdentifiable>();
            // List<IIdentifiable> robots = new List<IIdentifiable>();

            // List<IIdentifiable> robotsAndCitizens = new List<IIdentifiable>();
            //List<IBirthable> birthables = new List<IBirthable>();

            List<IBuyer> buyers = new List<IBuyer>();
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();

            //string command;
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split()
                    .ToArray();

                if(commandArgs.Length == 4)
                {
                    string name = commandArgs[0];
                    int age = int.Parse(commandArgs[1]);
                    string id = commandArgs[2];
                    string birthdate = commandArgs[3];
                    
                    if(!citizens.Any(c=>c.Name == name) && !rebels.Any(r=>r.Name == name))
                    {
                        Citizen citizen = new Citizen(name, age, id,birthdate);
                        
                        citizens.Add(citizen);
                        buyers.Add(citizen);
                    }

                    //  citizens.Add(citizen);
                   // robotsAndCitizens.Add(citizen);
                  //  birthables.Add(citizen);
                }
                else if(commandArgs.Length == 3)
                {
                    string name = commandArgs[0];
                    int age = int.Parse(commandArgs[1]);
                    string group = commandArgs[2];

                    if (!citizens.Any(c => c.Name == name) && !rebels.Any(r => r.Name == name))
                    {
                        Rebel rebel = new Rebel(name, age, group);

                        rebels.Add(rebel);
                        buyers.Add(rebel);
                    }


                }

            }
 
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string name = command;
                if(citizens.Any(c => c.Name == name))
                {
                    IBuyer buyer = citizens.Find(c => c.Name == name);
                    buyer.BuyFood();
                }
                else if(rebels.Any(r => r.Name == name))
                {
                    IBuyer buyer = rebels.Find(r => r.Name == name);
                    buyer.BuyFood();
                }
            }
            int sumFood = 0;
            foreach (IBuyer buyer in buyers)
            {
                sumFood += buyer.Food;
            }
            Console.WriteLine(sumFood);

            
           

        }
       
    }
}
