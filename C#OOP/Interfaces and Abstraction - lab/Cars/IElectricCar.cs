﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public interface IElectricCar : ICar
    {
        Battery Battery { get; }
    }
}
