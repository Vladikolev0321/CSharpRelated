using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class CatOnJet : Vehicle
    {
        public string Name { get; set; }

        public override string VrumVrum()
        {
            return "Cat is meowing";
        }
    }
}
