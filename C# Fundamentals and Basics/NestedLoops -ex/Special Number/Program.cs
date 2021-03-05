using System;

namespace Special_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = true;
            for(int i=1111;i<9999;i++)
            {
                isSpecial = true;
                string command = i.ToString();
                for(int j=0;j<command.Length;j++)
                {
                    int num = int.Parse(command[j].ToString());
                    if (num == 0)
                    {
                        isSpecial = false;
                        continue;
                    }
                    if (n%num!=0)
                    {
                       isSpecial = false;
                       break;
                    }
                }
                if(isSpecial)
                {
                    Console.Write($"{i} ");
                }
               

            }
        }
    }
}
