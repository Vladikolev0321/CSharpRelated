using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();
            if(pass.Length >= 6 && pass.Length <= 10 && pass.All(char.IsLetterOrDigit) && pass.Count(char.IsDigit) >= 2)
            {
                Console.WriteLine("Password is valid");
            }
            else 
            { 
            IsPassBetweenRequirements(pass);
            DoesConsistsOfLettersAndDigits(pass);
            DoesHaveAtLeast2Digits(pass);
            }
    }
        static void IsPassBetweenRequirements(string pass)
        {
            if(pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        }
        static void DoesConsistsOfLettersAndDigits(string pass)
        {
           if(!pass.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
        }
        static void DoesHaveAtLeast2Digits(string pass)
        {
            //int count = 0;
            //for (int i = 0; i < pass.Length; i++)
            //{
            //    if (char.IsDigit(pass[i]))
            //    {
            //        count++;
            //    }
            //}
            //if(count < 2)
            //{
            //    Console.WriteLine("Password must have at least 2 digits");
            //}
            if (pass.Count(char.IsDigit) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}
