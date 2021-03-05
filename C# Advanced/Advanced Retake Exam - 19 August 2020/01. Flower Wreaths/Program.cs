using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            int count_wraiths = 0;
            int stored_flowers = 0;
            while(lilies.Any() && roses.Any())
            {
                int sum = lilies.Peek() + roses.Peek();
                if(sum == 15)
                {
                    count_wraiths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if(sum > 15)
                {
                    int to_push = lilies.Pop() - 2;
                    lilies.Push(to_push);
                }
                else if(sum < 15)
                {
                    lilies.Pop();
                    roses.Dequeue();
                    stored_flowers += sum;
                }
            }
            while(stored_flowers > 0)
            {
                if(stored_flowers - 15 >= 0)
                {
                    count_wraiths++;
                    stored_flowers -= 15;
                }
                else
                {
                    break;
                }
            }

            if(count_wraiths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {count_wraiths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-count_wraiths} wreaths more!");
            }
        }
    }
}
