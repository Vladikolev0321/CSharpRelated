using System;
using System.Globalization;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //18 - 04 - 2016
            string date = Console.ReadLine();

            DateTime dateTime = DateTime.ParseExact(date,"dd-MM-yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime.DayOfWeek);
        }
    }
}
