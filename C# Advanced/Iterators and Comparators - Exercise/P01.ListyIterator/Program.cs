using System;
using System.Linq;

namespace P01.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] creationData = Console.ReadLine().Split();
            ListyIterator<string> collection;

            if(creationData.Length > 1)
            {
                collection = new ListyIterator<string>(creationData.Skip(1));
            }
            else
            {
                collection = new ListyIterator<string>();
            }

            string command;
            while((command = Console.ReadLine()) != "END")
            {
                if(command == "Move")
                {
                    Console.WriteLine(collection.Move());
                }
                else if(command == "HasNext")
                {
                    Console.WriteLine(collection.HasNext());
                }
                else if(command == "Print")
                {
                    try
                    {
                        collection.Print();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
                else if(command == "PrintAll")
                {
                    foreach (var item in collection)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                }


            }
        }
    }
}
