using System;
using System.Collections.Generic;

namespace _05.Students_2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }
                string[] info = input.Split();

                Student student = new Student();
                student.FirstName = info[0];
                student.LastName = info[1];
                student.Age = int.Parse(info[2]);
                student.HomeTown = info[3];

                list.Add(student);
            }
            string city = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].HomeTown == city)
                {
                    Console.WriteLine($"{list[i].FirstName} {list[i].LastName} is {list[i].Age} years old.");
                }
            }

        }
    }
}
