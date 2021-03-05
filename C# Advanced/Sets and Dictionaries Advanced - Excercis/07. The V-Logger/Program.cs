using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> vloggerWithHisFollowers = new
                Dictionary<string, HashSet<string>>();

            Dictionary<string, HashSet<string>> vloggerWithHisFowolling = new
                Dictionary<string, HashSet<string>>();

            string command;
            while((command = Console.ReadLine()) != "Statistics")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string operation = cmdArgs[1];

                if (operation == "joined")
                {
                    string vloggerToJoin = cmdArgs[0];

                    if (!vloggerWithHisFollowers.ContainsKey(vloggerToJoin))
                    {
                        vloggerWithHisFollowers[vloggerToJoin] = new HashSet<string>();
                        vloggerWithHisFowolling[vloggerToJoin] = new HashSet<string>();
                    }
                }
                else if(operation == "followed")
                {
                    string vloggerWhichFollowed = cmdArgs[0];
                    string vloggerFollowed = cmdArgs[2];
                    if(vloggerWithHisFollowers.ContainsKey(vloggerWhichFollowed) 
                        && vloggerWithHisFowolling.ContainsKey(vloggerFollowed)
                        && vloggerFollowed != vloggerWhichFollowed
                        && !vloggerWithHisFowolling[vloggerWhichFollowed].Contains(vloggerFollowed))
                    {
                        ///For the vlogger which followed the other one
                        vloggerWithHisFowolling[vloggerWhichFollowed].Add(vloggerFollowed);
                        ///For the followed vlogger
                        vloggerWithHisFollowers[vloggerFollowed].Add(vloggerWhichFollowed);
                    }
                }
            }
            //Ordering dict to be ordered by count of followers
            vloggerWithHisFollowers = vloggerWithHisFollowers
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => vloggerWithHisFowolling[kvp.Key].Count)
               // .ThenBy(kvp => vloggerWithHisFowolling[kvp.Key].Count)
                .ToDictionary(x => x.Key, y => y.Value);

            //vloggerWithHisFowolling = vloggerWithHisFowolling
            //    .OrderBy(kvp => kvp.Value.Count)
            //    .ThenBy(kvp => kvp.Value)
            //    .ToDictionary(x => x.Key, y => y.Value);
            /////

            //Best vlogger
            Console.WriteLine($"The V-Logger has a total of {vloggerWithHisFollowers.Count} vloggers in its logs.");
            Console.WriteLine($"1. {vloggerWithHisFollowers.First().Key}" +
                $" : {vloggerWithHisFollowers.First().Value.Count} followers," +
                $" {vloggerWithHisFowolling[vloggerWithHisFollowers.First().Key].Count} following");
            foreach (var follower in vloggerWithHisFollowers.First().Value.OrderBy(s => s))
            {
                Console.WriteLine($"*  {follower}");
            }
            /////The other vloggers
            int counter = 0;
            foreach (var kvp in vloggerWithHisFollowers)
            {
                if(counter == 0)
                {
                    counter++;
                    continue;
                }
                Console.WriteLine($"{counter + 1}. {kvp.Key} : {kvp.Value.Count} followers," +
                    $" {vloggerWithHisFowolling[kvp.Key].Count} following");

                counter++;
            }
        }
    }
}
