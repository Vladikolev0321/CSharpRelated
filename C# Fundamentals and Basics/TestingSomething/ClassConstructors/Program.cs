using System;

namespace ClassConsrtuctors
{
    class Person
    {
        public string name;
        public Person()
        {
            name = "Gosho";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person();
            // first.name = "Ivan";
            Console.WriteLine(first.name);
        }
    }
}
