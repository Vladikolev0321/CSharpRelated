using System;

namespace P08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
                .Split();
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string address = personInfo[2];
            string town = personInfo[3];

            string[] nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int beerAmount = int.Parse(nameAndBeer[1]);
            bool isDrunk = nameAndBeer[2] == "drunk" ? true : false;

            string[] bankArgs = Console.ReadLine().Split();
            string realName = bankArgs[0];
            double accountBalance = double.Parse(bankArgs[1]);
            string bankName = bankArgs[2];

            Threeuple<string, string, string> firstThreeuple = new
                Threeuple<string, string, string>(fullName, address, town);
            Threeuple<string, int, bool> secondThreeuple = new
                Threeuple<string, int, bool>(name, beerAmount, isDrunk);
            Threeuple<string, double, string> thirdThreeuple = new
                Threeuple<string, double, string>(realName, accountBalance, bankName);

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
