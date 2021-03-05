using P04._BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04._BorderControl.Models
{
    public class Citizen :  IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }
       // public string Name { get; }

        //public int Age { get; }

        //public string Id { get; }

        public string GetId()
        {
            return this.id;
        }
    }
}
