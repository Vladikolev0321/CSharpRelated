using System;

namespace ArrWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };

            string[] tokens = Console.ReadLine().Split();
            string command = tokens[0];
            if(command == "add")
            {
                int num = int.Parse(tokens[1]);
                int[] result = AddElement(arr,num);
                Console.WriteLine(string.Join(" ", result));
            }
            

            //Add 10
            //Remove 
            //Rotate Left
            //Switch 1 2 
        }

        static int[] AddElement(int[] arr, int num)
        {
            int[] arrNew = new int[arr.Length + 1];
            Array.Copy(arr, arrNew,arr.Length);
            arrNew[arrNew.Length - 1] = num;
            return arrNew;
        }
    }
}
