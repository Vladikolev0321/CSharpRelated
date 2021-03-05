using P03.Raiding.Models;
using P03.Raiding.Models.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03.Raiding.Core
{
    public class Engine 
    {
        private ICollection<BaseHero> heroes;
        private HeroFactory heroFactory;

        public Engine()
        {
            heroes = new List<BaseHero>();
            heroFactory = new HeroFactory();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                //try
                //{
                //    Validate(heroType);
                //}
                //catch (ArgumentException ae)
                //{
                //    Console.WriteLine(ae.Message);
                //    i--;
                //    continue;
                //}
                BaseHero hero;
                try
                {
                     hero = heroFactory.MakeHero(heroName, heroType);
                     heroes.Add(hero);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                   
                }
                
                
            }

            int bossPower = int.Parse(Console.ReadLine());
            int sumHeroPower = 0;
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                sumHeroPower += hero.Power;
            }
           // Console.WriteLine(sumHeroPower);
            ResultOfFight(bossPower, sumHeroPower);

        }

        private static void ResultOfFight(int bossPower, int sumHeroPower)
        {
            if (sumHeroPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        //private static void Validate(string heroType)
        //{
        //    if (heroType != "Druid" && heroType != "Paladin" && heroType != "Rogue"
        //                        && heroType != "Warrior")
        //    {
        //        throw new ArgumentException("Invalid hero!");
        //    }
        //}
    }
}
