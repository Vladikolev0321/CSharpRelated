using System;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input;
            while((input = Console.ReadLine()) != "Generate")
            {
                string[] command = input.Split(">>>").ToArray();
                if(command[0] == "Contains")
                {
                    string substr = command[1];
                    if (activationKey.Contains(substr))
                    {
                        Console.WriteLine($"{activationKey} contains {substr}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if(command[0] == "Flip")
                {
                    if(command[1] == "Upper")
                    {
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);
                        string oldString = activationKey.Substring(startIndex, endIndex - startIndex);
                        string newString = oldString.ToUpper();

                        activationKey = activationKey.Replace(oldString, newString);
                    }
                    else
                    {
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);

                        string oldString = activationKey.Substring(startIndex, endIndex - startIndex);
                        string newString = oldString.ToLower();

                        activationKey = activationKey.Replace(oldString, newString);
                    }
                    Console.WriteLine(activationKey);

                }
                else
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    string oldString = activationKey.Substring(startIndex, endIndex - startIndex);

                    activationKey = activationKey.Replace(oldString, "");

                    Console.WriteLine(activationKey);
                }

            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
