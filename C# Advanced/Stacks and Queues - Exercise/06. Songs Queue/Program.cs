using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                 .Split(", ")
                 .ToArray();

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Any())
            {
                string[] command = Console.ReadLine().Split();

                if(command[0] == "Play")
                {
                    queue.Dequeue();
                }
                else if(command[0] == "Add")
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(command[1]);
                    for (int i = 2; i < command.Length; i++)
                    {
                        sb.Append(" " + command[i]);
                    }
                    string songToAdd = sb.ToString();
                    if (!queue.Contains(songToAdd))
                    {
                        queue.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");

        }
    }
}
