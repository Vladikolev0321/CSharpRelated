﻿using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///na edin red
            string[] names = Console.ReadLine()
                .Split(", ")
              //  .Where(u => ValidateUsername(u))
                .ToArray();

            foreach (var username in names)
            {
                if (ValidateUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
            


        }
        private static bool ValidateUsername(string username)
        {

            if(username.Length<3 || username.Length > 16)
            {
                return false;
            }

            bool isValid = true;

            for (int i = 0; i < username.Length; i++)
            {
                char currentCh = username[i];
                if(!(char.IsLetterOrDigit(currentCh) || currentCh == '-' || currentCh == '_'))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }
    }
}
