using System;
using System.Security.Cryptography;

namespace RandomType
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            Console.WriteLine(result);
        }
    }
}
