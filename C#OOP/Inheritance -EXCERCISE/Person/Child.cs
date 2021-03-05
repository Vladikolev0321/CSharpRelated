using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Child : Person
    {
        private const int Child_max_age = 15;
        public Child(string name,int age) : base(name, age)
        {

        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            protected set
            {
                if (value <= 15)///Child_max_age
                {
                    base.Age = value;
                }

            }
        }
    }
}
