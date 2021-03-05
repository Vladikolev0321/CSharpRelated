using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Raiding.Models.Factory
{
    public class HeroFactory
    {
        public BaseHero MakeHero(string name,string type)
        {
            BaseHero hero = null;
            if(type == "Druid")
            {
                hero = new Druid(name);
            }
            else if(type == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if(type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if(type == "Warrior")
            {
                hero = new Warrior(name);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }

            return hero;
        }
    }
}
