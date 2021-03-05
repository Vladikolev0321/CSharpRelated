using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int nOrigin = N;
            int countPoked = 0;
            while (N >= M)
            {
                if (N == 0.5 * nOrigin)
                {
                    if (Y > 0)
                    { 
                        N /= Y; 
                        if(N < M)
                            {
                            break;
                            }
                    }
                }
                
                        N -= M;
                        countPoked++;
                    
                
            }
            Console.WriteLine(N);
            Console.WriteLine(countPoked);
        }
    }
}
