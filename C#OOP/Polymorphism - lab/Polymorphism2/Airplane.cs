using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Airplane : Vehicle
    {
        public int MaxPeople { get; set; }
        public override string VrumVrum()
        {
            return "Airplane is flying";
        }

        public string VrumVrum(int people)
        {
            return $"Airplane is flying with {people}";
        }
    }
}
