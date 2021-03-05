using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallsMaxCapacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split();

            Stack<string> inputLines = new Stack<string>(input);

            Dictionary<char, List<int>> hallsAndPeople = new Dictionary<char, List<int>>();

            Queue<char> halls = new Queue<char>();

            while (inputLines.Any())
            {
                char hallName;
                char.TryParse(inputLines.Peek(), out hallName);
                if (char.IsLetter(hallName))
                {
                    hallName = char.Parse(inputLines.Pop());

                    halls.Enqueue(hallName);
                    hallsAndPeople[hallName] = new List<int>();
                }
                else
                {
                    if (halls.Any())
                    {
                        char currHall = halls.Peek();
                        int peopleToJoin = int.Parse(inputLines.Peek());
                        if (hallsAndPeople[currHall].Sum() + peopleToJoin == hallsMaxCapacity)
                        {
                            hallsAndPeople[currHall].Add(peopleToJoin);
                            halls.Dequeue();
                            inputLines.Pop();
                            PrintHall(hallsAndPeople, currHall);
                        }
                        else if (hallsAndPeople[currHall].Sum() + peopleToJoin > hallsMaxCapacity)
                        {
                            halls.Dequeue();
                            PrintHall(hallsAndPeople, currHall);
                        }
                        else
                        {
                            hallsAndPeople[currHall].Add(peopleToJoin);
                            //halls.Dequeue();
                            inputLines.Pop();
                        }
                    }
                    else
                    {
                        inputLines.Pop();
                    }

                }
            }
        }

        private static void PrintHall(Dictionary<char, List<int>> hallsAndPeople, char currHall)
        {
            Console.WriteLine($"{currHall} -> " +
                                        $"{string.Join(", ", hallsAndPeople[currHall])}");
        }
    }
}
