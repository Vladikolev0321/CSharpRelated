using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Telephony.Contracts
{
    public interface ICallable
    {
        string Call(string number);
    }
}
