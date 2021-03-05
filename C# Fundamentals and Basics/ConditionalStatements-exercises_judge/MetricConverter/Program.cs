using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string unit = Console.ReadLine();
            string toConvertUnit = Console.ReadLine();

            if(unit == "mm" )
            {
                if(toConvertUnit == "cm" )
                {
                    number = number / 10;
                }
                else
                {
                    number = number / 1000;
                }
            }
            else if(unit =="cm")
            {
                if(toConvertUnit == "mm")
                {
                    number = number * 10;
                }
                else
                {
                    number = number / 100;
                }
            }
            else
            {
                if(toConvertUnit == "mm")
                {
                    number = number * 1000;
                }
                else
                {
                    number = number * 100;
                }
            }
            Console.WriteLine($"{number:F3}");
        }
    }
}
