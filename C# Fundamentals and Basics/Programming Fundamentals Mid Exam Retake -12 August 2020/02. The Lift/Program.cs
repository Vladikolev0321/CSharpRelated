using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < lift.Length && peopleWaiting != 0; i++)
            {
                if(lift[i] < 4)
                {
                    int peopleCanEnter = 4 - lift[i];
                    if(peopleWaiting >= peopleCanEnter)
                    {
                        peopleWaiting -= peopleCanEnter;
                        lift[i] += peopleCanEnter;
                    }
                    else if(peopleWaiting < peopleCanEnter)
                    {
                        while(peopleWaiting > 0)
                        {
                            peopleWaiting--;
                            lift[i]++;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }


            if(peopleWaiting == 0 && lift.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ',lift));
            }
            else if(peopleWaiting > 0 && lift.All(w => w == 4))
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(' ', lift));
            }
            else if(lift.All(w => w == 4) && peopleWaiting == 0)
            {
                Console.WriteLine(string.Join(' ', lift));
            }
        }
    }
}
