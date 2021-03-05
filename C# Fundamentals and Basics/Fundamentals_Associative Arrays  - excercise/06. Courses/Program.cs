using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string inp = Console.ReadLine();
                if(inp == "end")
                {
                    break;
                }
                string[] command = inp.Split(" : ");

                string courseName = command[0];
                string studentName = command[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                  //  courses[courseName].Add(studentName);
                }
                courses[courseName].Add(studentName);
            }

            Dictionary<string, List<string>> sortedCourses = courses
                .OrderByDescending(kvp => kvp.Value.Count)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in sortedCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var student in kvp.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
                
        }
    }
}
