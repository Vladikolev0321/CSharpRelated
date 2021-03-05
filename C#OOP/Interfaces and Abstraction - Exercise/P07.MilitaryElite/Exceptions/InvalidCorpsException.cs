using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        private const string DEF_MESS = "Ivalid corps";
        public InvalidCorpsException()
            :base(DEF_MESS)
        {
        }

        public InvalidCorpsException(string message)
            : base(message)
        {
        }

       // public static string 
    }
}
