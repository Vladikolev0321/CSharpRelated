using System;
using System.Text;

namespace _01._Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Complete")
                {
                    break;
                }
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Make":
                        if (command[1] == "Upper")
                        {
                            email = email.ToUpper();
                            Console.WriteLine(email);
                        }
                        else
                        {
                            email = email.ToLower();
                            Console.WriteLine(email);
                        }
                        break;
                    case "GetDomain":
                        int count = int.Parse(command[1]);
                        string sub = email.Substring(email.Length-count);
                        Console.WriteLine(sub);
                        break;
                    case "GetUsername":
                        if (email.Contains('@'))
                        {
                            int ind = email.IndexOf('@');
                            StringBuilder sb = new StringBuilder();
                            foreach (char c in email)
                            {
                                if (c == '@')
                                {
                                    break;
                                }
                                sb.Append(c);
                            }
                            Console.WriteLine(sb);
                        }
                        else
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        break;
                    case "Replace":
                        char toReplace = char.Parse(command[1]);
                        email = email.Replace(toReplace, '-');
                        Console.WriteLine(email);
                        break;
                    case "Encrypt":
                        for (int i = 0; i < email.Length; i++)
                        {
                            char currCh = email[i];
                            Console.Write($"{(int)currCh} ");
                        }
                        break;
                }
            }
        }
    }
}
