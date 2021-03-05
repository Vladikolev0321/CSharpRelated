using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locksInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsInfo);
            Queue<int> locks = new Queue<int>(locksInfo);

            int countShooting = 0;
            int bulletsCost = 0;
            while(bullets.Any() && locks.Any())
            {
                int currBullet = bullets.Pop();
                countShooting++;            
                if(currBullet <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (countShooting == sizeGunBarrel && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    countShooting = 0;
                }
                bulletsCost += bulletPrice;
                
            }


            if (!locks.Any())
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned " +
                    $"${intelligenceValue - bulletsCost}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }



        }
    }
}
