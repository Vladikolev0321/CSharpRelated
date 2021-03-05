using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private readonly List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count => this.data.Count;

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }
        public void Remove(string name)
        {
            this.data.Remove(this.data.FirstOrDefault(h => h.Name == name));
        }
        public Hero GetHeroWithHighestStrength()
        {
           // int maxItemStrength = this.data.Max(h => h.Item.Strength);
            return this.data.FirstOrDefault(h => h.Item.Strength == this.data.Max(he => he.Item.Strength));
        }
        public Hero GetHeroWithHighestAbility()
        {
            return this.data.FirstOrDefault(h => h.Item.Ability == this.data.Max(he => he.Item.Ability));

        }
        public Hero GetHeroWithHighestIntelligence()
        {
            return this.data.FirstOrDefault(h => h.Item.Intelligence == this.data.Max(he => he.Item.Intelligence));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < this.Count; i++)
            {
                sb.AppendLine(this.data[i].ToString());
            }

            return sb.ToString().TrimEnd();
        }


    }
}
