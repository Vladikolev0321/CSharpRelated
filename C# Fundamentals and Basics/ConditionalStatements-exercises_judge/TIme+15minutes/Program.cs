using System;

namespace TIme_15minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
           // Console.WriteLine(minutes);
           //if minutes are like 01 they are used as 1
           if(hour>=0 && hour<=23 && minutes>=0 && minutes<=59)
            {
                if(minutes+15<=59)
                {
                    
                        Console.WriteLine($"{hour}:{minutes+15}");
                    
                }
                else
                {
                    int sum = minutes + 15;
                    minutes = sum - 60;
                    if (hour + 1 == 24)
                    {
                        hour = 0;
                    }
                    else
                    {
                        hour++;
                    }
                    if(minutes<10)
                    {
                        Console.WriteLine($"{hour}:0{minutes}");
                    }
                    else
                        Console.WriteLine($"{hour}:{minutes}");

                
                }
            }
        }
    }
}
