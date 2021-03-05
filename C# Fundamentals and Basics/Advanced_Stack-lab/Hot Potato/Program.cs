using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new Queue<int>();

            //numbers.Enqueue(1);
            //numbers.Enqueue(2);
            //numbers.Enqueue(3);

            var names = Console.ReadLine().Split();
            int toss = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(names);

            int currentIndex = 1;

            while(queue.Count>1)
            {
                var currentName = queue.Dequeue();

                if(currentIndex == toss)
                {
                    Console.WriteLine($"Remove {currentName}");
                    currentIndex = 0;
                }
                else
                {
                    queue.Enqueue(currentName);
                }
                currentIndex++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
