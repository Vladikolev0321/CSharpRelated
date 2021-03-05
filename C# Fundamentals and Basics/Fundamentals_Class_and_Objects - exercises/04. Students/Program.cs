using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName,string lastName ,float grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public override string ToString()
        {
            // return base.ToString();
            return $"{this.FirstName} { this.LastName}: { this.Grade:F2}";
            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split();
                string firstName = info[0];
                string lastName = info[1];
                float grade = float.Parse(info[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            //students.OrderByDescending(x => x.Grade);
            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine(students[i].ToString());
            //}

            foreach (Student student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(student.ToString());
            }

        }
    }
}
