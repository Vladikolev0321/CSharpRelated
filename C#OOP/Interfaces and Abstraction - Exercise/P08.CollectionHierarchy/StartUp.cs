using P08.CollectionHierarchy.Models;
using System;

namespace P08.CollectionHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] firstLine = Console.ReadLine()
                .Split();

            for (int i = 0; i < firstLine.Length; i++)
            {
                string element = firstLine[i];

                addCollection.Add(element);
                addRemoveCollection.Add(element);
                myList.Add(element);
            }

            int countRemoveOperations = int.Parse(Console.ReadLine());
            for (int i = 0; i < countRemoveOperations; i++)
            {
                addRemoveCollection.Remove();
                myList.Remove();
            }

            Console.WriteLine(addCollection);
            Console.WriteLine(addRemoveCollection);
            Console.WriteLine(myList);

            addRemoveCollection.GetRemoved();
            myList.GetRemoved();
        }
    }
}
