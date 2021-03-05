using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelf = Console.ReadLine().Split("&").ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                string[] command = input.Split(" | ");

                switch (command[0])
                {
                    case "Add Book":
                        if (!shelf.Contains(command[1]))
                        {
                            shelf.Insert(0, command[1]);
                        }
                        break;
                    case "Take Book":
                        if (shelf.Contains(command[1]))
                        {
                            shelf.Remove(command[1]);
                        }
                        break;
                    case "Swap Books":
                        if (shelf.Contains(command[1]) && shelf.Contains(command[2]))
                        {
                            int ind1 = shelf.IndexOf(command[1]);
                            int ind2 = shelf.IndexOf(command[2]);

                            string temp = shelf[ind1];
                            shelf[ind1] = shelf[ind2];
                            shelf[ind2] = temp;
                        }
                        break;
                    case "Insert Book":
                        shelf.Add(command[1]);
                        break;
                    case "Check Book":
                        int index = int.Parse(command[1]);
                        if (index >= 0 && index < shelf.Count)
                        {
                            Console.WriteLine(shelf[index]);
                        }
                        break;

                }
            }
            Console.WriteLine(string.Join(", ", shelf));
        }
    }
}
