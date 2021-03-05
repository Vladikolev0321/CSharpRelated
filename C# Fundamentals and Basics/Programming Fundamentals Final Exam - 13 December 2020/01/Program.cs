using System;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string input;
            while((input = Console.ReadLine()) != "Sign up")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(command[0] == "Case")
                {
                    if(command[1] == "lower")
                    {
                        username = username.ToLower();
                    }
                    else
                    {
                        username = username.ToUpper();
                    }

                    Console.WriteLine(username);
                }
                else if(command[0] == "Reverse")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if(startIndex >= 0 && endIndex < username.Length)
                    {
                        string substr = username.Substring(startIndex, endIndex - startIndex + 1);
                        char[] subsArray = substr.ToCharArray();

                        Array.Reverse(subsArray);

                        string res = new string(subsArray);
                        Console.WriteLine(res);
                    }
                }
                else if(command[0] == "Cut")
                {
                    string subs = command[1];

                    if(username.Contains(subs))
                    {
                        int index = username.IndexOf(subs);
                        username = username.Remove(index, subs.Length);
                        Console.WriteLine(username);
                        ////////not sure
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {subs}.");
                    }
                }
                else if(command[0] == "Replace")
                {
                    char cToReplace = char.Parse(command[1]);
                    username = username.Replace(cToReplace, '*');

                    Console.WriteLine(username);
                }
                else
                {
                    char cToCheck = char.Parse(command[1]);
                    if(username.Contains(cToCheck))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {cToCheck}.");
                    }
                }
            }
        }
    }
}
