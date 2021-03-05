using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
           int sumSteps = 0;
           bool goalReached = false;
           while(sumSteps < 10000)
            {
                string command = Console.ReadLine();
               
                if (command == "Going home")
                {
                    int stepsback = int.Parse(Console.ReadLine());
                    sumSteps = sumSteps + stepsback;
                    if(sumSteps >= 10000)
                    {   
                        goalReached = true;
                        break;
                    }
                    else
                    {
                        goalReached = false;
                        break;
                    }
                        
                }
                else
                {   int steps = int.Parse(command);
                    sumSteps = sumSteps + steps;
                }
               // Console.WriteLine(steps);
            }
           if(sumSteps >= 10000)
            {
                goalReached = true;
            }
            
           if(goalReached)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sumSteps - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - sumSteps} more steps to reach goal.");
                
            }

        }
    }
}
