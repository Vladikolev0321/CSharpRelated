using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destoyedPlanets = new List<string>();



            string pattern = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attack>[AD])![^@\-!:>]*->(?<soldiers>\d+)";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int specialNumber = SpecialLettersCount(encryptedMessage);
                string decryptedMessage = DecryptMessage(encryptedMessage, specialNumber);

                var match = Regex.Match(decryptedMessage, pattern);
                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    string attackType = match.Groups["attack"].Value;

                    if(attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destoyedPlanets.Add(planetName);
                    }
                }
            }
            PrintOutputForPlanets(attackedPlanets, "Attacked");
            PrintOutputForPlanets(destoyedPlanets, "Destroyed");

        }
        private static void PrintOutputForPlanets(List<string> planets,string attackType)
        {
            Console.WriteLine($"{attackType} planets:" +
                $" {planets.Count}");

            foreach (var planet in planets.OrderBy(a=>a))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
        private static string DecryptMessage(string encrypted,int key)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < encrypted.Length; i++)
            {
                char currentCh = encrypted[i];
                char decryptedCh = (char)(currentCh - key);
                sb.Append(decryptedCh);

            }
            return sb.ToString();
        }
        private static int SpecialLettersCount(string message)
        {
            char[] specialLetters = new char[] { 's', 't', 'a', 'r' };

            int specialLettersCount = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char currentCh = message[i];

                if (specialLetters.Contains(Char.ToLower(currentCh)))
                {
                    specialLettersCount++;
                }
            }

            return specialLettersCount;
        }
    }
}
