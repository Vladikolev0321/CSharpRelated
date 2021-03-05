using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> listNames = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                if(input[2] == "going!")
                {
                    if (!listNames.Contains(name))
                    {
                    listNames.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }

                }
                else
                {
                    if (listNames.Contains(name))
                    {
                        listNames.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                

            }
            for (int i = 0; i < listNames.Count; i++)
            {
                Console.WriteLine(listNames[i]);
            }
        }
    }
}
