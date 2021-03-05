using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        //Battery Battery { get; }

        string Start();
        string Stop();
        
    }
}
