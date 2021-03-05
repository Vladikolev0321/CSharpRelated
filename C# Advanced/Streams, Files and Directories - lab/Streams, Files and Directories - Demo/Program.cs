using System;
using System.IO;

namespace Streams__Files_and_Directories___Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  FileStream stream = new FileStream("text.txt", FileMode.OpenOrCreate);
            //FileStream file = new FileStream(@"..\..\text.txt", FileMode.Open);

            //  FileStream file = new FileStream("text.txt", FileMode.Open); 

            //StreamWriter writer = new StreamWriter("result.txt");

            /////using gurantees that the stream will be closed after stopping the process
            //using (writer)
            //{
            //  //  writer.WriteLine("Test");
            //   // writer.Write("Another");
            //}

            //StreamReader reader = new StreamReader("text.txt");

            //string result = reader.ReadLine();

            //Console.WriteLine(result);


            ///// or other way
            //// using StreamWriter writer = new StreamWriter("result.txt");
            /////    writer.Write("Test");c
            ////    writer.Write("Another");
            /////   

            //FileStream stream2 = new FileStream("result.dat", FileMode.OpenOrCreate);

            ////using var writer2 = new BinaryWriter(stream2);

            ////writer2.Write(true);
            ////writer2.Write(false);
            ////writer2.Write(true);

            //using var reader2 = new BinaryReader(stream2);

            //var first = reader2.ReadBoolean();
            //var second = reader2.ReadBoolean();
            //var third = reader2.ReadBoolean();

            //Console.WriteLine(first);


            using var reader = new StreamReader("text.txt");
            using var writer = new StreamWriter("output.txt");

            int count = 1;

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                var convertedLine = $"{count}.{line}";

                writer.WriteLine(convertedLine);

                count++;
            }
        }
    }
}
