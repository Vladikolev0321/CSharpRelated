using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Exceptions
{
    public class InvalidMissionCompletionException : Exception
    {
        private const string DEF_MSG = "Mission already completed";
        public InvalidMissionCompletionException()
            :base(DEF_MSG)
        {
        }

        public InvalidMissionCompletionException(string message) : base(message)
        {
        }
    }
}
