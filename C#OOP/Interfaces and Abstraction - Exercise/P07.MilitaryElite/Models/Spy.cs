using P07.MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine
                + $"Code Number: {this.CodeNumber}";
        }
    }
}
