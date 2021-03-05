using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        private int age;
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.age}";

        }
    }
}
