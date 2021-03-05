using System;
using System.Collections.Generic;
using System.Text;

namespace P04._BorderControl.Contracts
{
    public interface IRobot
    {
        string Model { get; }
        string Id { get; }
    }
}
