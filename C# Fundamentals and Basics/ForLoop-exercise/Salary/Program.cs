using System;
using System.ComponentModel.DataAnnotations;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int nBrowsers = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for(int i=0; i < nBrowsers; i++)
            {
                if (salary <= 0)
                {
                    break;
                }

                string nameBrowser = Console.ReadLine();
                if(nameBrowser == "Facebook")
                {
                    salary = salary - 150;
                }
                else if(nameBrowser == "Instagram")
                {
                    salary = salary - 100;
                }
                else if(nameBrowser == "Reddit")
                {
                    salary = salary - 50;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
