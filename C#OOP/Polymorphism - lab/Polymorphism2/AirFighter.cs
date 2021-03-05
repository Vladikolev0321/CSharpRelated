using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class AirFighter : Airplane
    {
        public int Damage { get; set; }

        public override string VrumVrum()
        {
            return "Fighter is fighting";
        }
    }
}
