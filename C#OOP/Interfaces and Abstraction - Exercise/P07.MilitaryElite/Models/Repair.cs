using P07.MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partname , int hoursWorked)
        {
            this.PartName = partname;
            this.HoursWorked = hoursWorked;
        }
        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}
