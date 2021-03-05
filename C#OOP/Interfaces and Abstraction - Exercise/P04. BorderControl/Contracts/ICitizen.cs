using System;
using System.Collections.Generic;
using System.Text;

namespace P04._BorderControl.Contracts
{
    public interface ICitizen
    {
        string Name { get; }
        int Age { get; }
        string Id { get; }
    }
}
