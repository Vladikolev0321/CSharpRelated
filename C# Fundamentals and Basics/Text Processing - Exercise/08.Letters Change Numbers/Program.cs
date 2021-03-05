using System;
using System.Linq;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                sum = ProcessWord(words, sum, i);
            }
            Console.WriteLine($"{sum:F2}");
        }

        private static double ProcessWord(string[] words, double sum, int i)
        {
            double tempSum = 0;

            string currWord = words[i];
            char firstLetter = currWord[0];
            char lastLetter = currWord[currWord.Length - 1];
            ParseeNumberFromInput(currWord);

            double number = ParseeNumberFromInput(currWord);

            tempSum += number;
            int firstLetterPos = GetAlphabeticalPosByLetter(firstLetter);
            int lastLetterPos = GetAlphabeticalPosByLetter(lastLetter);



            if (char.IsUpper(firstLetter) && firstLetterPos > 0)
            {
                tempSum /= firstLetterPos;
            }
            else if (char.IsLower(firstLetter) && firstLetterPos > 0)
            {
                tempSum = number * firstLetterPos;
            }

            if (char.IsUpper(lastLetter) && lastLetterPos > 0)
            {
                tempSum -= lastLetterPos;
            }
            else if (char.IsLower(lastLetter) && lastLetterPos > 0)
            {
                tempSum += lastLetterPos;
            }
            sum += tempSum;
            return sum;
        }

        static int GetAlphabeticalPosByLetter(char letter)
        {
            int position = -1;
            if (char.IsLetter(letter))
            {
                if (char.IsUpper(letter))
                {
                    position = letter - 64;
                }
                else
                {
                    position = letter - 96;
                }
                
            }
            return position;

        }

        private static double ParseeNumberFromInput(string currWord)
        {
            char[] numberAsChar = currWord.Skip(1)
                .Take(currWord.Length - 2)
                .ToArray();

            string numberAsString = String.Join("", numberAsChar);

            double number = double.Parse(numberAsString);
            return number;
        }
        // static int 
    }
}
