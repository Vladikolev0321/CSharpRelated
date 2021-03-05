using System;

namespace CinemaTIckets
{
    class Program
    {
        static void Main(string[] args)
        {
            float ticketsCount = 0;
            int standardCount = 0;
            int studentCount = 0;
            int kidCount = 0;

            int sumStandard = 0;
            int sumStudent = 0;
            int sumKid = 0;
            float sumTickets = 0;
            string command = Console.ReadLine();
            
            while(command != "Finish")
            {
                float freespace = float.Parse(Console.ReadLine());
                string typeTicket = Console.ReadLine();
                while(typeTicket != "End"&&typeTicket != "Finish")
                {   
                   
                    ticketsCount++;
                    if(typeTicket == "standard")
                    {
                        standardCount++;
                        
                    }
                    else if(typeTicket == "kid")
                    {
                        kidCount++;
                    }
                    else if(typeTicket == "student")
                    {
                        studentCount++;
                    }
                    typeTicket = Console.ReadLine();
                   // typeTicket = Console.ReadLine();
                    
                }
                if (typeTicket == "Finish")
                {
                    Console.WriteLine($"{command} - {(ticketsCount / freespace) * 100:F2}% full.");
                    sumTickets += ticketsCount;
                    sumStandard += standardCount;
                    sumKid += kidCount;
                    sumStudent += studentCount;
                    Console.WriteLine($"Total tickets: {sumTickets}");
                    Console.WriteLine($"{(sumStudent/sumTickets)*100:F2}% student tickets.");
                    Console.WriteLine($"{ (sumStandard/sumTickets)*100:F2}% standard tickets.");
                    Console.WriteLine($"{ (sumKid/sumTickets)*100:F2}% kids tickets.");
                    break;
                }
                else
                {
                    Console.WriteLine($"{command} - {(ticketsCount / freespace) * 100:F2}% full.");
                    sumTickets += ticketsCount;
                    sumStandard += standardCount;
                    sumKid += kidCount;
                    sumStudent += studentCount;
                    standardCount = 0;
                    kidCount = 0;
                    studentCount = 0;
                    ticketsCount = 0;
                    command = Console.ReadLine();
                }
            }
           

        }
    }
}
