using System;

namespace OnTImeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examhour = int.Parse(Console.ReadLine());
            int examminutes = int.Parse(Console.ReadLine());
            int hourThere = int.Parse(Console.ReadLine());
            int minutesThere = int.Parse(Console.ReadLine());

            int examInMinutes = examhour * 60 + examminutes;
            int ThereInMinutes = hourThere * 60 + minutesThere;
          //  Console.WriteLine(examInMinutes);
          //  Console.WriteLine(ThereInMinutes);
             
            if(ThereInMinutes > examInMinutes)
            {
                Console.WriteLine("Late");
                if(ThereInMinutes - examInMinutes < 60)
                {
                    Console.WriteLine($"{ThereInMinutes - examInMinutes} minutes after the start");
                }
                else
                {
                    if ((ThereInMinutes - examInMinutes) % 60 >= 10)
                    {
                        Console.WriteLine($"{(ThereInMinutes - examInMinutes) / 60}:{(ThereInMinutes - examInMinutes) % 60} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{(ThereInMinutes - examInMinutes) / 60}:0{(ThereInMinutes - examInMinutes) % 60} hours after the start");
                    }
                }
            }
            else if((ThereInMinutes == examInMinutes) || (ThereInMinutes >= examInMinutes - 30) )
            {
                Console.WriteLine("On time");
                if(ThereInMinutes >= examInMinutes - 30)
                {
                    Console.WriteLine($"{examInMinutes - ThereInMinutes} minutes before the start");
                }
            }
            else if( ThereInMinutes < examInMinutes - 30)
            {
                Console.WriteLine("Early");
                if(examInMinutes - ThereInMinutes >=60)
                {   if ((examInMinutes - ThereInMinutes) % 60 >= 10)
                        Console.WriteLine($"{(examInMinutes - ThereInMinutes) / 60}:{(examInMinutes - ThereInMinutes) % 60} hours before the start");
                    else
                    {
                        Console.WriteLine($"{(examInMinutes - ThereInMinutes) / 60}:0{(examInMinutes - ThereInMinutes) % 60} hours before the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{examInMinutes - ThereInMinutes} minutes before the start");
                }
            }

        }
    }
}
