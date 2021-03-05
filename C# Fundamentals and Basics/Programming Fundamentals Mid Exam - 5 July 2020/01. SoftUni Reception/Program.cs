using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsPerHour1 = int.Parse(Console.ReadLine());
            int studentsPerHour2 = int.Parse(Console.ReadLine());
            int studentsPerHour3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int allStudentsPerHour = studentsPerHour1 + studentsPerHour2 + studentsPerHour3;
            int timeNeeded = 0;

            while(studentsCount > 0)
            {
                timeNeeded += 1;
                if (timeNeeded % 4 == 0)
                {
                    timeNeeded += 1;
                }
                if (allStudentsPerHour >= studentsCount)
                {
                    break;
                }
                else
                {
                    studentsCount -= allStudentsPerHour;
                }
            }

            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
