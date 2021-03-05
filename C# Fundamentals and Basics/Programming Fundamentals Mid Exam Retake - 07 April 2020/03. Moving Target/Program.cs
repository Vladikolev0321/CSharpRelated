using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ').ToArray();
                if(command[0] == "Shoot")
                {
                    int index = int.Parse(command[1]);
                    int power = int.Parse(command[2]);
                    if(index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if(targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if(command[0] == "Add")
                {
                    int index = int.Parse(command[1]);
                    int value = int.Parse(command[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if(command[0] == "Strike")
                {
                    int index = int.Parse(command[1]);
                    int radius = int.Parse(command[2]);

                    if (index < 0 && index >= targets.Count)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                    if(index - radius >= 0 && index + radius < targets.Count)
                    {
                        for (int i = index - radius,counter = 0; counter <= radius + 1; i++,counter++)
                        {
                            targets.RemoveAt(i);
                            i--;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                }
                else{
                    break;
                }

            }

            Console.WriteLine(string.Join('|', targets));


        }
    }
}
