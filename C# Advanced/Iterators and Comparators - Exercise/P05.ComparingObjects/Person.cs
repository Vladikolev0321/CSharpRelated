using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace P05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name,int age , string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo([AllowNull] Person person)
        {
            int result = 1;
            if(person != null)
            {
                result = this.Name.CompareTo(person.Name);
                if(result == 0)
                {
                    result = this.Age.CompareTo(person.Age);
                    if(result == 0)
                    {
                        result = this.Town.CompareTo(this.Town);
                    }
                }

            }
            return result;

        }
    }
}
