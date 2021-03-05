using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Vehicles.Models.Contracts
{
    public interface IRefueable
    {
        void Refuel(double liters);
    }
}
