using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double scholarshipForResults = averageSuccess * 25 ;
            double socialScholarship = minimalSalary * 0.35;
            
            if(averageSuccess>=5.5 && income < minimalSalary )
            {
                if(scholarshipForResults > socialScholarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarshipForResults)} BGN");
                }
                else if(scholarshipForResults < socialScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarshipForResults)} BGN");
                }
            }
            
            else if(averageSuccess >= 5.5)
            {   
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarshipForResults)} BGN");
            }
            else if(income<minimalSalary && averageSuccess>4.5 )
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

        }
    }
}
