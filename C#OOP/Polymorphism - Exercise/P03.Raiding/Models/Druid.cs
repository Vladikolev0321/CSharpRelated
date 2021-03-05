using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int power = 80;

        public Druid(string name)
            : base(name, power)
        {
        }

        //public override int Power 
        //{
        //    get
        //    {
        //        return power;
        //    }
        //}

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
