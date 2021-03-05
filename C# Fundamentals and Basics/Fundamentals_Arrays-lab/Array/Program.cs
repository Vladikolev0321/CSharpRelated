using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[3];
            ages[0] = 5;
            ages[1] = 6;
            ages[2] = 7;

            /*foreach(int age in ages)
            {
                Console.WriteLine(age);
            }*/
            for (int i = 0; i < ages.Length; i++)
            {
                Console.WriteLine(ages[i]);
            }
        }
    }
}
