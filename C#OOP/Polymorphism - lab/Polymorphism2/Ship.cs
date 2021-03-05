using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Ship : Vehicle
    {
        public int MaxDepth { get; set; }
        public override string VrumVrum()
        {
            return "Ship is floating";
        }
    }
}
