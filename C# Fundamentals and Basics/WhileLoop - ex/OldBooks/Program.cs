using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string bookName = Console.ReadLine();
            int countbooks = 0;
            bool isfound = false;

            while (bookName != "No More Books") 
            {
                if (bookName == searchedBook)
                {
                    isfound = true;
                    break;
                }
                else
                {
                    countbooks++;
                    bookName = Console.ReadLine();
                }
            }
            if(isfound == true)
            {
                Console.WriteLine($"You checked {countbooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countbooks} books.");
            }
        }
    }
}
