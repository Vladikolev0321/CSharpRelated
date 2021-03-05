using System;
using System.Collections.Generic;
using System.Text;

namespace P05.BirthdayCelebrations
{
    public interface ICitizen
    {
        string Name { get; }
        int Age { get; }
        string Id { get; }
    }
}
