using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        private const int Person_min_age = 0;

        private string name;
        private int age;

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }
        public virtual int Age 
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if(value >= 0)
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Name: {this.Name}, Age: {this.Age}");

            return sb.ToString();
        }

    }
}
