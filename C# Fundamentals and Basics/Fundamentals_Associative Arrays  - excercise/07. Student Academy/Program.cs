using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grade);
            }

            Dictionary<string, double> studentsAverage = new Dictionary<string, double>();

            foreach (var kvp in students)
            {
                studentsAverage[kvp.Key] = kvp.Value.Average();
            }

            studentsAverage = studentsAverage
                .Where(kvp => kvp.Value >= 4.50)
                .OrderByDescending(kvp => kvp.Value)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in studentsAverage)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
