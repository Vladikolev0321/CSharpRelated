using System;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");

            for(int i = 0; i < lines.Length; i++)
            {
                string currLine = lines[i];

                int lettersCnt = CountOfLetters(currLine);
                int marksCnt = CountOfPunctuonalMarks(currLine);

                lines[i] = $"Line {i + 1}: {currLine} ({lettersCnt})({marksCnt})";

            }

            File.WriteAllLines("../../../output.txt", lines);

        }
        static int CountOfLetters(string line)
        {
            int cnt = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char currChar = line[i];
                if (char.IsLetter(currChar))
                {
                    cnt++;
                }
            }
            return cnt;
        }
        static int CountOfPunctuonalMarks(string line)
        {
            char[] marks = { '-', ',', '.', '!', '?' };

            int cnt = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char curChar = line[i];
                if (marks.Contains(curChar))
                {
                    cnt++;
                }
            }

            return cnt;
        }
        
    }
}
