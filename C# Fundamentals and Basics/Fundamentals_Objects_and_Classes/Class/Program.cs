using System;
using System.Collections.Generic;
using System.Globalization;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] myArray = new string[10];
            //myArray.Length;
            
            // var birthday = new { day = 22, month = 6 , year = 1990};////Making class on one line

            //Cat cat = new Cat();
            //cat.Name = "Maca";
            //Console.WriteLine(cat.Name);

            string input = "07-13-2020";
          //  DateTime dateTime = DateTime.Parse(input);
            DateTime dateTime = DateTime.ParseExact(input, "MM-dd-yyyy", CultureInfo.InvariantCulture);


            dateTime = dateTime.AddDays(2);

            Console.WriteLine(dateTime.DayOfWeek);
            ////////////////////////////
            ///

            Cat cat = new Cat();
            cat.Eat(); 

            Console.WriteLine(cat.Fat);

            ///////////
            ///CONSTRUCTORS
          //  var list = new List<string>(20);

            Cat cat2 = new Cat();
            
            cat2.Kittens.Add("Maci");
            //cat2.Kittens = new List<string>(); WITHOUT CONSTUCTOR

            foreach (var name in cat2.Kittens)
            {
                Console.WriteLine(name);
            }
            ////////////////////
            ///

            //// List<Cat>



        }
    }
}
