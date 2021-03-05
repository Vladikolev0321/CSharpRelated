using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public class SaltWaterAquarium : Aquarium
    {
        public SaltWaterAquarium(string name)
            : base(name, 25)
        {
        }
    }
}
