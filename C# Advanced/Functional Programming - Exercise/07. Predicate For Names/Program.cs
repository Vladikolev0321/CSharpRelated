using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split();

            Predicate<string> filterForNames = new Predicate<string>((name)
                => name.Length <= length);

            Action<string[]> FiltersNames = new Action<string[]>((names) =>
             {
                 foreach (string name in names)
                 {
                     if (filterForNames(name))
                     {
                         Console.WriteLine(name);
                     }
                 }
                //return names;
 
             });
            FiltersNames(names);

        }
    }
}
