using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            int movesMade = 0;
            string input;
            bool haveWon = false;

            while((input = Console.ReadLine()) != "end")
            {
                int[] indexes = input.Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int index1 = indexes[0];
                int index2 = indexes[1];
                movesMade++;

                if(index1 < 0 || index1 >= list.Count || index2 < 0 || index2 >= list.Count
                   || index1 == index2)
                {
                    int indexToAddTo = list.Count / 2;
                    string elemToAdd2Times = $"-{movesMade}a";
                    list.Insert(indexToAddTo, elemToAdd2Times);
                    list.Insert(indexToAddTo, elemToAdd2Times);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if(list[index1] == list[index2])
                    {
                        string elToDelete = list[index1];
                        Console.WriteLine($"Congrats! You have found matching elements - {list[index1]}!");
                        list.RemoveAll(i => i == elToDelete);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }

                    if (!list.Any())
                    {
                        haveWon = true;
                        break;
                    }
                }

            }
            if (haveWon)
            {
                Console.WriteLine($"You have won in {movesMade} turns!");
            }
            else
            {
                Console.WriteLine($"Sorry you lose :(\n" +$"{string.Join(' ',list)}");
            }

        }
    }
}
