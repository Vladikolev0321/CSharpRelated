using System;

namespace Objects
{
   
    class Program { 
        static void Main(string[] args)
        {
            Cars firstcar = new Cars();
            Cars secondcar = new Cars();
            firstcar.color = "blue";
            secondcar.color = "red";
            Console.WriteLine(firstcar.color);
            Console.WriteLine(secondcar.color);
            Console.WriteLine(firstcar.maxSpeed);
            firstcar.Suobsht();
            //Console.WriteLine("Hello World!");
        }
    }
}
