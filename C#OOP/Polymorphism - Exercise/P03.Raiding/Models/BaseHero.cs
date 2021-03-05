using _3._Raiding.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Raiding.Models
{
    public abstract class BaseHero:ICastAbilitable
    {
        protected BaseHero(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }
       public string Name { get; private set; }
       public  int Power { get; private set; }
       public abstract string CastAbility();
       
    }
}
