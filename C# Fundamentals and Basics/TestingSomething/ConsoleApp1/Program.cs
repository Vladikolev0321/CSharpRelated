using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello SoftUni");

            /* string name = "Vladi ";
             string family_name = "Kolev";
             string fullname = name + family_name;
             Console.WriteLine(fullname);
             Console.WriteLine(name + family_name);*/

            /*            Console.WriteLine("ENter user:");
                        string user = Console.ReadLine();
                        Console.WriteLine("Username is " + user);*/


            /* Console.WriteLine("Enter AGE:");
             int age = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Age e " + age);
             */

            /* int x = 4;
            // int y = 6;int z = 4;
             Console.WriteLine(Math.Sqrt(x));
             Console.WriteLine(Math.Abs(-4.7));
             Console.WriteLine(Math.Round(9.99));
             */
            string txt = "Vladislav Kolev";
            Console.WriteLine(txt.Length);
            txt = txt.ToUpper();
            //Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt);
            Console.WriteLine(txt.IndexOf("K"));

            int surnamPos = txt.IndexOf("K");
            string lastname = txt.Substring(surnamPos);
            Console.WriteLine(lastname);


        }
    }
}
