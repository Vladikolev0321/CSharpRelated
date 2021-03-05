using P03.Telephony.Contracts;
using P03.Telephony.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03.Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
    
        public string Call(string number)
        {
            if (!number.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidNumberException();
            }
            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if(url.Any(ch => char.IsDigit(ch)))
            {
                throw new InvalidUrlException();
            }
            return $"Browsing: {url}!";
        }

    }
}
