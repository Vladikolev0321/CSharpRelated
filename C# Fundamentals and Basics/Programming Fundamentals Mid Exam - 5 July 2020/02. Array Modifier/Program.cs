using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;
            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if(command[0] == "swap")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    int tmp = arr[index1];
                    arr[index1] = arr[index2];
                    arr[index2] = tmp;
                }
                else if(command[0] == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    arr[index1] = arr[index1] * arr[index2];
                }
                else
                {
                    for(int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--;
                    }
                }


            }

            Console.WriteLine(string.Join(", ", arr));

        }
    }
}
