using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string grade =Console.ReadLine();

            countDays = countDays - 1;
            double price = 0;
            switch(typeRoom)
            {
                case "room for one person":
                    price = countDays * 18;
                    break;
                case "apartment":
                    price = countDays * 25;
                    if (countDays < 10)
                    {
                        price = price - price * 0.3;
                    }
                    else if (countDays >= 10 && countDays <= 15)
                    {
                        price = price - price * 0.35;
                    }
                    else
                    {
                        price = price - price * 0.5;
                    }
                    break;
                case "president apartment":
                    price = countDays * 35;
                    if (countDays < 10)
                    {
                        price = price - price * 0.1;
                    }
                    else if (countDays >= 10 && countDays <= 15)
                    {
                        price = price - price * 0.15;
                    }
                    else
                    {
                        price = price - price * 0.2;
                    }
                    break;
            }
            if(grade == "positive")
            {
                price = price + price * 0.25;
            }
            else
            {
                price = price - price * 0.1; 
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
