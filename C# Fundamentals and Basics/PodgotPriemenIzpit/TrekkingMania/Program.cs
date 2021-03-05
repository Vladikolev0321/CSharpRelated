using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            double countMus = 0;
            double countMon = 0;
            double countKili = 0;
            double countK2 = 0;
            double countEver = 0;
            double peopleCount = 0;
            int groups = int.Parse(Console.ReadLine());
            for(int i=0;i<groups;i++)
            {
                
                int people = int.Parse(Console.ReadLine());
                peopleCount += people;
                if (people <= 5)
                {
                    countMus += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    countMon += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    countKili += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    countK2 += people;
                }
                else if(people>=41)
                {
                    countEver += people;
                }
            }
            Console.WriteLine($"{countMus/peopleCount*100:F2}%");
            Console.WriteLine($"{countMon / peopleCount * 100:F2}%");
            Console.WriteLine($"{countKili / peopleCount * 100:F2}%");
            Console.WriteLine($"{countK2 / peopleCount * 100:F2}%");
            Console.WriteLine($"{countEver / peopleCount * 100:F2}%");



        }
    }
}
