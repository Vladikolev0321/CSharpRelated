using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;
            while (n > 0)
            {
                n -= capacity;
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
