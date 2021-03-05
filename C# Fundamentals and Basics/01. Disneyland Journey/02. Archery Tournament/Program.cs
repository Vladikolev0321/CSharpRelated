using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split("|").Select(int.Parse).ToArray();
            int points = 0;
            while (true)
            {
                string inp = Console.ReadLine();
                if(inp == "Game over")
                {
                    break;
                }
                string[] command = inp.Split("@");               
                switch (command[0])
                {
                    case "Shoot Left":
                        int startIndex = int.Parse(command[1]);
                        int length = int.Parse(command[2]);
                        //int position = ;
                        if(startIndex >= 0 && startIndex < targets.Length)
                        {
                            
                                for (int i = 0; i < length; i++)
                                {
                                    startIndex--;
                                    if(startIndex == -1)
                                    {
                                        startIndex = targets.Length - 1;
                                    }
                                }     
                                if(targets[startIndex] >= 5)
                                {
                                     targets[startIndex] -= 5;
                                     points += 5;
                                }
                                 else if (targets[startIndex] > 0)
                                 {
                                    points += targets[startIndex];
                                    targets[startIndex] = 0;
                                 }


                        }
                        break;
                    case "Shoot Right":
                        int startInd = int.Parse(command[1]);
                        int len = int.Parse(command[2]);
                        //int position = ;
                        if (startInd >= 0 && startInd < targets.Length)
                        {

                            for (int i = 0; i < len; i++)
                            {
                                startInd++;
                                if (startInd == targets.Length)
                                {
                                    startInd = 0;
                                }
                            }
                            if (targets[startInd] >= 5)
                            {
                                targets[startInd] -= 5;
                                points += 5;
                            }
                            else if(targets[startInd] > 0)
                            {
                                points += targets[startInd];
                                targets[startInd] = 0;
                            }

                        }
                        break;
                    case "Reverse":
                        targets = targets.Reverse().ToArray();
                        break;

                }
                //if (inp == "Reverse")
                //{
                //        targets = targets.Reverse().ToArray();
                //}
            }
            Console.WriteLine(string.Join(" - ", targets));
           Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }
    }
}
