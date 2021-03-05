using System;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input;
            while((input = Console.ReadLine()) != "Reveal")
            {
                string[] command = input.Split(":|:");
                if(command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);
                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if(command[0] == "Reverse")
                {
                    string subs = command[1];
                    if (message.Contains(subs))
                    {
                        int startIndex = message.IndexOf(subs);
                        message = message.Remove(startIndex, subs.Length);
                        char[] subsArr = subs.ToCharArray();
                        Array.Reverse(subsArr);
                        string reversedSubstr = new string(subsArr);
                        message += reversedSubstr;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }
                else
                {
                    string subs = command[1];
                    string replacement = command[2];
                    message = message.Replace(subs, replacement);

                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
