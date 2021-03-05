using System;
using System.Linq;
using System.Reflection;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int countShotTargets = 0;

            string command;
            while((command = Console.ReadLine()) != "End")
            {
                int indexToShoot = int.Parse(command);
                
                if(indexToShoot < 0 || indexToShoot >= targets.Length || targets[indexToShoot] == -1)
                {
                    continue;
                }

                int shotTargetValue = targets[indexToShoot];
                targets[indexToShoot] = -1;
                countShotTargets++;

                for(int i = 0; i < targets.Length; i++)
                {
                    if(targets[i] > shotTargetValue)
                    {
                        targets[i] -= shotTargetValue;
                    }
                    else if(targets[i] <= shotTargetValue && targets[i] != -1)
                    {
                        targets[i] += shotTargetValue;
                    }
                }
            }

            Console.WriteLine($"Shot targets: {countShotTargets} -> {string.Join(' ',targets)}");

        }
    }
}
