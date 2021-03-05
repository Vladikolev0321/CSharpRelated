using System;

namespace _05.Digits_Letters_and_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string allDigits = "";
            string allLetters = "";
            string everythingElse = "";

            foreach (char symbol in text)
            {
                if(char.IsDigit(symbol))
                {
                    allDigits += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    allLetters += symbol;
                }
                else
                {
                    everythingElse += symbol;
                }
            }
            Console.WriteLine(allDigits);
            Console.WriteLine(allLetters);
            Console.WriteLine(everythingElse);
        }
    }
}
