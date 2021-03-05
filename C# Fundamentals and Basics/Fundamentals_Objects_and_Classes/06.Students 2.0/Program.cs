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
            List<Student> students = new List<Student>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] info = input.Split();

                if (IsStudentExisting(students, info[0], info[1]))
                {
                    Student student = GetStudent(students, info[0], info[1]);
                    student.FirstName = info[0];
                    student.LastName = info[1];
                    student.Age = int.Parse(info[2]);
                    student.HomeTown = info[3];

                }
                else
                {
                    Student student = new Student();
                    student.FirstName = info[0];
                    student.LastName = info[1];
                    student.Age = int.Parse(info[2]);
                    student.HomeTown = info[3];

                    students.Add(student);
                }
            }
            string city = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].HomeTown == city)
                {
                    Console.WriteLine($"{students[i].FirstName} {students[i].LastName} is {students[i].Age} years old.");
                }
            }

        }
        static bool IsStudentExisting(List<Student> students,string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if(student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> students , string firstName , string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
    }
}
