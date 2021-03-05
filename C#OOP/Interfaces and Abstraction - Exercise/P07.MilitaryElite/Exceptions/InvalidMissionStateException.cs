using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Exceptions
{
    public class InvalidMissionStateException : Exception
    {
        private const string DEF_MSG = "Invalid mission state";
        public InvalidMissionStateException()
            :base(DEF_MSG)
        {
        }

        public InvalidMissionStateException(string message)
            : base(message)
        {
        }
    }
}
