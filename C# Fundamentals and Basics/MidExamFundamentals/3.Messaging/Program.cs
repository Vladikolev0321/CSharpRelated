using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> log = new List<string>();
            string input;
            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                if(command[0] == "Chat")
                {
                    string message = command[1];
                    log.Add(message);
                }
                else if(command[0] == "Delete")
                {
                    string messToDelete = command[1];
                    if(log.Any(m => m == messToDelete))
                    {
                        log.Remove(messToDelete);
                    }
                }
                else if(command[0] == "Edit")
                {
                    string messToEdit = command[1];
                    string editedVers = command[2];

                    int index = log.FindIndex(i => i == messToEdit);
                    log[index] = editedVers;
                }
                else if(command[0] == "Pin")
                {
                    string message = command[1];
                    log.Remove(message);
                    log.Add(message);
                }
                else if(command[0] == "Spam")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        log.Add(command[i]);
                    }
                }
            }

            Console.WriteLine(string.Join('\n', log));
        }
    }
}
