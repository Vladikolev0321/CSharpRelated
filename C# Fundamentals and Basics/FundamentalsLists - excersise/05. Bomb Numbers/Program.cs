using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNum = input[0];
            int bombPower = input[1];
            list = Detonate(list, bombNum, bombPower);
            Console.WriteLine(list.Sum());

        }
        static List<int> Detonate(List<int> list,int bombNum,int bombPower)
        {
            int index = 0;
            while (list.Contains(bombNum))
            {
                index = list.IndexOf(bombNum);
                int leftRange = bombPower;
                int rightRange = bombPower;
                if(index - leftRange < 0)
                {
                    leftRange = index;
                }
                if(index + rightRange >= list.Count)
                {
                    rightRange = list.Count - index - 1;
                }
                list.RemoveRange(index - leftRange, leftRange + rightRange + 1);
            }
            return list;
        }
    }
}
