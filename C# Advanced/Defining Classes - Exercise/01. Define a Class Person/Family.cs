using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }


      //  public IReadOnlyCollection<Person> People
       //     => (IReadOnlyCollection<Person>) this.people;

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(p => p.Age).First();
        }
        public void FilterMembersWithAgeLowerThanOrEqualThan30()
        {
            this.members = this.members
                .Where(m => m.Age > 30)
                .OrderBy(m => m.Name)
                .ToList();
        }

    }
}
