using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(clothes);

            int rackCapacity = int.Parse(Console.ReadLine());

            int racksCount = 1;
            int sumOfClothes = 0;

            while (stack.Any())
            {
                sumOfClothes += stack.Peek();           
                if(sumOfClothes < rackCapacity)
                {
                    stack.Pop();
                }
                else if(sumOfClothes == rackCapacity)
                {
                    //racksCount++;
                    stack.Pop();
                    //sumOfClothes = stack.Pop();

                }
                else
                {
                    racksCount++;
                    sumOfClothes = stack.Pop();
                }
            }

            Console.WriteLine(racksCount);


        }
    }
}
