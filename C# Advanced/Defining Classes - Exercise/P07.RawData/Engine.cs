using System;
using System.Collections.Generic;
using System.Text;

namespace P07.RawData
{
    public class Engine
    {
        public Engine(int speed,int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
        public int Speed { get; private set; }
        public int Power { get; private set; }

    }
}
