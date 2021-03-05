using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Softuni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if(command[0] == "register")
                {
                    string user = command[1];
                    string plate = command[2];

                    if (!parking.ContainsKey(user))
                    {
                        parking[user] = plate;

                        Console.WriteLine($"{user} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[user]}");
                    }
                }
                else if(command[0] == "unregister")
                {
                    string user = command[1];                   
                    if (!parking.Any(c => c.Key == user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        parking.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                        //foreach (var kvp in parking)
                        //{
                        //    if(kvp.Key == user)
                        //    {
                        //        parking.Remove(kvp.Key);
                        //    }
                        //}
                    }
                }
            }
            foreach (var kvp in parking)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

        }
    }
}
