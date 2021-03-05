using System;

namespace AreaOfFiqueres
{
    class Program
    {
        static void Main(string[] args)
        {
            string fiquare = Console.ReadLine();
            double result = 0;

            switch (fiquare)
            {
                case "square":
                    double side = double.Parse(Console.ReadLine());
                    result = side * side;
                    break;
                case "rectangle":
                    double length = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    result = length * width;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    result = radius * radius * Math.PI;
                    break;
                case "triangle":
                    double side1 = double.Parse(Console.ReadLine());
                    double side2 = double.Parse(Console.ReadLine());
                    result = (side1 * side2) / 2;
                    break;

            }
            Console.WriteLine($"{result:F3}");
        }
    }
}
