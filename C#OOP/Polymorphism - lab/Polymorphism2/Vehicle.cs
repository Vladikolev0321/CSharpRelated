using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Vehicle : IVehicle
    {
        public string Model { get; set; }

        public virtual string VrumVrum()
        {
            return "Vehicle is moving";
        }
    }
}
