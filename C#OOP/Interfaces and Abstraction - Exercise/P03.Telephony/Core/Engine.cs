using P03.Telephony.Contracts;
using P03.Telephony.Exceptions;
using P03.Telephony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03.Telephony.Core
{
    class Engine : IEngine
    {
        public void Run()
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split()
                .ToArray();
            string[] sites = Console.ReadLine()
                .Split()
                .ToArray();

            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            CallNumbers(phoneNumbers, stationaryPhone, smartphone);
            BrowseSites(sites, smartphone);

        }

        private static void BrowseSites(string[] sites, Smartphone smartphone)
        {
            foreach (var url in sites)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(url));
                }
                catch (InvalidUrlException iue)
                {
                    Console.WriteLine(iue.Message);
                }
            }
        }

        private static void CallNumbers(string[] phoneNumbers, StationaryPhone stationaryPhone, Smartphone smartphone)
        {
            foreach (var number in phoneNumbers)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        Console.WriteLine(smartphone.Call(number));
                    }
                    else
                    {
                        throw new InvalidNumberException();
                    }

                }
                catch (InvalidNumberException ine)
                {

                    Console.WriteLine(ine.Message);
                }

            }
        }
    }
}
