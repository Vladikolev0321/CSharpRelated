using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger maxSnowballValue = 0;
            int maxsnowballTime = 0;
            int maxsnowballSnow = 0;
            int maxsnowballQuality = 0;
           // string max = "";
            for (int i = 0; i < N; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuality);
                if(snowballValue > maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    maxsnowballQuality = snowballQuality;
                    maxsnowballSnow = snowballSnow;
                    maxsnowballTime = snowballTime;
                    //max = "${maxsnowballSnow} : {maxsnowballTime} = {maxSnowballValue} ({maxsnowballQuality})";
                }
            }
            Console.WriteLine($"{maxsnowballSnow} : {maxsnowballTime} = {maxSnowballValue} ({maxsnowballQuality})");
        }
    }
}
