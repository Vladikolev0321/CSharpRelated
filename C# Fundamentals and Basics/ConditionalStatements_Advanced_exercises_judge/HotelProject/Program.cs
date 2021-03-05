using System;

namespace HotelProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());

            double moneyStudio = 0;
            double moneyApartment = 0;
            switch(month)
            {
                case "May":
                case "October":
                    moneyStudio = countDays * 50;
                    moneyApartment = countDays * 65;

                    if(countDays > 14)
                    {
                        moneyStudio = moneyStudio - moneyStudio * 0.3;
                        moneyApartment = moneyApartment - moneyApartment * 0.1;
                    }
                    else if(countDays>7)
                    {
                        moneyStudio = moneyStudio - moneyStudio * 0.05;
                    }
                   
                    
                    break;
                case "June":
                case "September":
                    moneyStudio = countDays * 75.20;
                    moneyApartment = countDays * 68.70;

                    if(countDays > 14)
                    {
                        moneyStudio = moneyStudio - moneyStudio * 0.2;
                        moneyApartment = moneyApartment - moneyApartment * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    moneyStudio = countDays * 76;
                    moneyApartment = countDays * 77;
                    if(countDays > 14)
                    {
                        moneyApartment = moneyApartment - moneyApartment * 0.1;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: { moneyApartment:F2} lv.");
            Console.WriteLine($"Studio: {moneyStudio:F2} lv.");
          
        }
    }
}
