using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int power = 100;

        public Paladin(string name) 
            : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
