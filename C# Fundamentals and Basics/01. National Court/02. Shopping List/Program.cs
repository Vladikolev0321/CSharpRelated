using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('!').ToList();

            string input;
            while((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split().ToArray();
                if(command[0] == "Urgent")
                {
                    string itemToAdd = command[1];
                    if(!list.Any(item => item == itemToAdd))
                    {
                        list.Insert(0, itemToAdd);
                    }
                }
                else if(command[0] == "Unnecessary")
                {
                    string itemToRemove = command[1];
                    if(list.Any(item => item == itemToRemove))
                    {
                        list.Remove(itemToRemove);
                    }
                }
                else if(command[0] == "Correct")
                {
                    string oldItem = command[1];
                    string newItem = command[2];

                    if(list.Any(item => item == oldItem))
                    {
                        ////////////
                        int indexofOldItem = list.FindIndex(item => item == oldItem);
                        list[indexofOldItem] = newItem;
                    }
                }
                else if(command[0] == "Rearrange")
                {
                    string item = command[1];
                    if(list.Any(it => it == item))
                    {
                        list.Remove(item);
                        list.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
