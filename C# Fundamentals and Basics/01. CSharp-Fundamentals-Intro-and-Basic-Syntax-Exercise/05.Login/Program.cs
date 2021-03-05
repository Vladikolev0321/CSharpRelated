using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int lenght = username.Length - 1;
            while (lenght >= 0)
            {
                password = password + username[lenght];
                lenght--;
            }
            //Console.WriteLine(password);
            string command = Console.ReadLine();
            int counter = 0;
            bool isBanned = false;
            while(command != password)
            {
                if(counter+1 == 4)
                {
                    isBanned = true;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
              //  Console.WriteLine("Counter: {counter}");
                
                command = Console.ReadLine();
                counter++;
            }
            if (isBanned)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }

        }
    }
}
