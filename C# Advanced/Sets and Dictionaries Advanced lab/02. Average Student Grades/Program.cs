using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] studentArgs = Console.ReadLine()
                    .Split();
                string studentName = studentArgs[0];
                decimal studentGrade = decimal.Parse(studentArgs[1]);

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<decimal>();
                }
                students[studentName].Add(studentGrade);
            }

            foreach (var kvp in students)
            {
                Console.Write($"{kvp.Key} -> ");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.WriteLine($"(avg: {kvp.Value.Average():F2})");

            }
        }
    }
}
