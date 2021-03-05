using System;
using System.Runtime.CompilerServices;

namespace P07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
                .Split();
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string address = personInfo[2];

            string[] nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int beerAmount = int.Parse(nameAndBeer[1]);

            string[] thirdInput = Console.ReadLine().Split();
            int firstArg = int.Parse(thirdInput[0]);
            double secondArg = double.Parse(thirdInput[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, address);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, beerAmount);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(firstArg, secondArg);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);

        }
    }
}
