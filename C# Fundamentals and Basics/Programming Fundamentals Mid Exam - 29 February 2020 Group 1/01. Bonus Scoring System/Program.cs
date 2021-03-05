using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int countLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttend = 0;
            for (int i = 0; i < countStudents; i++)
            {
                int currAttendance = int.Parse(Console.ReadLine());
                double currBonus = ((1.0*currAttendance / countLectures)) * (5 + initialBonus);

                if(currBonus > maxBonus)
                {
                    maxBonus = currBonus;
                    maxAttend = currAttendance;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttend} lectures.");
        }
    }
}
