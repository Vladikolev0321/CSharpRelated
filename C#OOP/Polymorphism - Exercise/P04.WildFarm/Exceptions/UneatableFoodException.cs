using System;
using System.Collections.Generic;
using System.Text;

namespace P04.WildFarm.Exceptions
{
    public class UneatableFoodException : Exception
    {
        
        public UneatableFoodException(string message)
            : base(message)
        {
        }
    }
}
