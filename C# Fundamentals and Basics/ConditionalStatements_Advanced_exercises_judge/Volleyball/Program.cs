using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {

            string typeYear = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double countPlayedGames = 0;
           // Console.WriteLine(p * 2 / 3);
            countPlayedGames = ((48 - h)* 0.75 + h  + (p * 2/3) );
           // Console.WriteLine(countPlayedGames);
            if(typeYear == "leap")
            {
                countPlayedGames = countPlayedGames + countPlayedGames * 0.15; 
            }
            Console.WriteLine(Math.Floor(countPlayedGames));

        }
    }
}
