using System;
using System.Linq;

namespace _03.Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            string[] pathArgs = path
                .Split('\\', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] fileInfo = pathArgs.Last()
                .Split('.');


            string[] filenameArgs =fileInfo.Take(fileInfo.Length - 1)
                .ToArray();


            string fileName = string.Join(".", filenameArgs);
            string fileExtension = fileInfo.Last();

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
