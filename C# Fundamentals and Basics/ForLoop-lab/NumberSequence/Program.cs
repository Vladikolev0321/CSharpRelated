﻿using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            
            for(int i=0;i<n;i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(max < num) { max = num; }
                if(min > num) { min = num; }

            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
