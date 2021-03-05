using System;
using System.Data;
using System.Linq;

namespace _09.KaminoFactory_Working_
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int LeftMostStartingIndex = -1;
            int MaxSeq = 0;
            int maxSeqIndex = -1;
            int[] MaxArray = new int[length];
            int seqCounter = 0;

            string command;
            while((command = Console.ReadLine()) != "Clone them!")
            {
                int[] currSequence = command
                    .Split('!')
                    .Select(int.Parse)
                    .ToArray();

                

                int startingIndex = 0;
                int sequnceLength = 0;
                for (int i = 0; i < currSequence.Length; i++)
                {
                    if(currSequence[i] == 1)
                    {
                        startingIndex = i;
                        sequnceLength++;
                    }
                    else
                    {
                       if(MaxSeq < sequnceLength)
                        {
                            MaxSeq = sequnceLength;
                            LeftMostStartingIndex = startingIndex;
                            maxSeqIndex = seqCounter;

                            currSequence.CopyTo(MaxArray,0);
                        }
                       else if(MaxSeq == sequnceLength)
                        {
                            if(LeftMostStartingIndex > startingIndex)
                            {
                                MaxSeq = sequnceLength;
                                LeftMostStartingIndex = startingIndex;

                                maxSeqIndex = seqCounter;

                                currSequence.CopyTo(MaxArray, 0);
                            }

                        }
                        startingIndex = 0;
                        sequnceLength = 0;

                    }
                }
                seqCounter++;
            }


            Console.WriteLine($"Best DNA sample {maxSeqIndex + 1} with sum: {MaxArray.Sum()}.");
            Console.WriteLine(string.Join(" ", MaxArray));
        }
    }
}
