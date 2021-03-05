using System;

namespace ClassProperties
{
    class Person
    {
        private string name = "Private";
        public string Name
        {
            get { return name;  }
            set { name = value;  }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person();
           // first.Name = "Public";
            Console.WriteLine(first.Name);
        }
    }
}
