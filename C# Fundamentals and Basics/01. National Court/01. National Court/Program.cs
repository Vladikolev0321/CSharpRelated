using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeoplePerHour1 = int.Parse(Console.ReadLine());
            int countPeoplePerHour2 = int.Parse(Console.ReadLine());
            int countPeoplePerHour3 = int.Parse(Console.ReadLine());

            int allPeoplePerHour = countPeoplePerHour1 + countPeoplePerHour2 + countPeoplePerHour3;

            int peopleCount = int.Parse(Console.ReadLine());
            int timeNeeded = 0;
            while(peopleCount > 0)
            {
                timeNeeded++;
                if(timeNeeded % 4 == 0)
                {
                    timeNeeded++;
                }
                if (allPeoplePerHour >= peopleCount)
                {
                    break;
                }
                else
                {
                    peopleCount -= allPeoplePerHour;
                }
            }
            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
