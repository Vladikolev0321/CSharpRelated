using System;

namespace Concatanate
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string grad = Console.ReadLine();

            // Console.WriteLine("You are"+ firstname +lastname, a -years old person from <town>.");
            Console.WriteLine($"You are {firstname} {lastname}, a {age}-years old person from {grad}.");
        }
    }
}
