using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04.OpinionPoll
{
    public class Family
    {
        private readonly List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }


        public IReadOnlyCollection<Person> Members
            => this.members;

        public void AddMember(Person member)
        {
            this.members.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(p => p.Age).First();
        }
    }
}
