using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBadGradesNeeded = int.Parse(Console.ReadLine());
            string nameOfExcercise = Console.ReadLine();
            int grade = 0;
            int countWorseGrades = 0;
            int countAllGrades = 0;
            double sumgrades = 0;
            string lastExcercise = "";
            while (nameOfExcercise != "Enough" && countBadGradesNeeded != countWorseGrades)
            {
                grade = int.Parse(Console.ReadLine());
                lastExcercise = nameOfExcercise;
                if (grade <= 4)
                {
                    countWorseGrades++;
                }
                else
                {
                    countAllGrades++;
                }
                sumgrades = sumgrades + grade;
                nameOfExcercise = Console.ReadLine();
                
            }
            if(nameOfExcercise == "Enough")
            {
                Console.WriteLine($"Average score: {sumgrades /(countAllGrades + countWorseGrades):F2}");
                Console.WriteLine($"Number of problems: {countWorseGrades+countAllGrades}");
                Console.WriteLine($"Last problem: {lastExcercise}");
            }
            else
            {
                Console.WriteLine($"You need a break, { countWorseGrades} poor grades.");
            }

        }
    }
}
