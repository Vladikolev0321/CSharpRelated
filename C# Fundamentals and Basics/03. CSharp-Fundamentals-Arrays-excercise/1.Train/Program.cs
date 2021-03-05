using System;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int sumPeople = 0;
            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sumPeople += train[i];
            }

            foreach (var item in train)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(sumPeople);
        }
    }
}
