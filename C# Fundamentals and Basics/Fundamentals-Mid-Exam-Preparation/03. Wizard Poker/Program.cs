using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(":").ToList();
            List<string> deck = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Ready")
                {
                    break;
                }
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        if (list.Contains(command[1]))
                        {
                            deck.Add(command[1]);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Insert":
                        string cardName = command[1];
                        int index = int.Parse(command[2]);
                        if (list.Contains(command[1]) && index >= 0 && index <= deck.Count)
                        {
                            deck.Insert(index, cardName);
                        }
                        else
                        {
                            Console.WriteLine("Error!");
                        }
                        break;
                    case "Remove":
                        if (deck.Contains(command[1]))
                        {
                            deck.Remove(command[1]);
                        }
                        else
                        {
                            Console.WriteLine("Card not found.");
                        }
                        break;
                    case "Swap":
                        string card1 = command[1];
                        string card2 = command[2];

                        int ind1 = deck.IndexOf(card1);
                        int ind2 = deck.IndexOf(card2);

                        string temp = deck[ind1];
                        deck[ind1] = deck[ind2];
                        deck[ind2] = temp;
                        break;
                    case "Shuffle":
                        deck.Reverse();
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", deck));
        }
    }
}
