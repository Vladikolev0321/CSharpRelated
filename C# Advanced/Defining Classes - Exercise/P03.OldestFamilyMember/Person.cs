using System;
using System.Collections.Generic;
using System.Text;

namespace P03.OldestFamilyMember
{
    public class Person
    {
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int age)
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        public string Name { get; private set; }
        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
