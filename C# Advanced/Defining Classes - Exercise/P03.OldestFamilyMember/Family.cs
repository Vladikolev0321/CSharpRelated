using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03.OldestFamilyMember
{
    public class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }
        public List<Person> Members { get; set; }

        //  public IReadOnlyCollection<Person> People
        //     => (IReadOnlyCollection<Person>) this.people;

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.Members.OrderByDescending(p => p.Age).First();
        }
    }
}
