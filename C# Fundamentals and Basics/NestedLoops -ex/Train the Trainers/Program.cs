using System;

namespace Train_the_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumAllGrades = 0;
            int countPresentations = 0;

            string command = Console.ReadLine();
            while(command != "Finish")
            {   
                double sum = 0;
                double avr = 0;
                for(int i=0;i<n;i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    sumAllGrades += grade;
                    countPresentations++;
                }
                avr = sum / n;
                Console.WriteLine($"{command} - {avr:F2}.");



                command = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {sumAllGrades/countPresentations:F2}.");
        }
    }
}
