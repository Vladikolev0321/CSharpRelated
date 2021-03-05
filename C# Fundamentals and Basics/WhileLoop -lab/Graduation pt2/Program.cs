using System;

namespace Graduation_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 0;
            double sumMarks = 0;
            int timesBadGrades = 0;
            bool isExcluded = false;
            while(grade < 12)
            {
                double mark = double.Parse(Console.ReadLine());
                if(mark >= 4)
                {
                    sumMarks += mark; 
                    grade++;
                }
                else
                {
                    timesBadGrades++;
                    if(timesBadGrades > 1)
                    {
                        isExcluded = true;
                        break;
                    }
                    else
                    {
                        grade++;
                    }
                }
            }

        if(isExcluded == true)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
        else
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumMarks / grade:F2}");

            }
        }
    }
}
