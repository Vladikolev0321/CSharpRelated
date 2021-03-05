﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Dwarfs
{
    class SleepyDwarf : Dwarf
    {
        public SleepyDwarf(string name)
            : base(name, 50)
        {
        }
        public override void Work()
        {
            base.Work();
            this.Energy -= 5;
        }
    }
}
