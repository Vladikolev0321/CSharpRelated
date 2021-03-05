using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if(typeGroup == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price = peopleCount * 8.45;
                        break;
                    case "Saturday":
                        price = peopleCount * 9.80;
                        break;
                    case "Sunday":
                        price = peopleCount * 10.46;
                        break;
                }
                if(peopleCount >= 30)
                {
                    price -= price * 0.15;
                }
            }
            else if(typeGroup == "Business")
            {
                if(peopleCount >= 100)
                {
                    peopleCount -= 10;
                }
                switch (day)
                {
                    case "Friday":
                        price = peopleCount * 10.90;
                        break;
                    case "Saturday":
                        price = peopleCount * 15.60;
                        break;
                    case "Sunday":
                        price = peopleCount * 16;
                        break;
                }
                
            }
            else
            {
                switch (day)
                {
                    case "Friday":
                        price = peopleCount * 15;
                        break;
                    case "Saturday":
                        price = peopleCount * 20;
                        break;
                    case "Sunday":
                        price = peopleCount * 22.50;
                        break;
                }
                if(peopleCount >= 10 && peopleCount <= 20)
                {
                    price -= price * 0.05;
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
