using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();

            int indexOfCupid = 0;
            string input;
            while((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split();
                int jumpLength = int.Parse(command[1]);
                
                if(indexOfCupid + jumpLength < arr.Length && arr[indexOfCupid + jumpLength] != 0)
                {
                    indexOfCupid += jumpLength;
                    arr[indexOfCupid] -= 2;
                    if(arr[indexOfCupid] == 0)
                    {
                        Console.WriteLine($"Place {indexOfCupid} has Valentine's day.");
                    }

                }
                else if(indexOfCupid + jumpLength < arr.Length &&  arr[indexOfCupid + jumpLength] == 0)
                {
                    indexOfCupid += jumpLength;
                    Console.WriteLine($"Place {indexOfCupid} already had Valentine's day.");
                }
                else
                {
                    indexOfCupid = 0;
                    if(arr[indexOfCupid] == 0)
                    {
                        Console.WriteLine($"Place {indexOfCupid} already had Valentine's day.");
                    }
                    else
                    {
                        arr[indexOfCupid] -= 2;
                        if (arr[indexOfCupid] == 0)
                        {
                            Console.WriteLine($"Place {indexOfCupid} has Valentine's day.");
                        }
                    }
                }
            }
            Console.WriteLine($"Cupid's last position was {indexOfCupid}.");
            if(arr.All(h => h == 0))
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                int countFailedHouses = arr.Count(h => h != 0);
                Console.WriteLine($"Cupid has failed {countFailedHouses} places.");
            }
        }
    }
}
