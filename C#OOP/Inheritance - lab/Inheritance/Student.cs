using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Student:Person
    {

        public string School { get; set; } 

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
