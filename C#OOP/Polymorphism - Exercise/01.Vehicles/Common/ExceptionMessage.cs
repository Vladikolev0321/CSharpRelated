using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Vehicles.Common
{
    public static class ExceptionMessage
    {
        public static string NotEnoughFuelExceptionMessage = "{0} needs refueling";
        public static string InvalidTypeVehicleExceptionMessage = "Invalid vehicle type";
        public static string InvalidFuelTankExceptionMessage = "Cannot fit {0} fuel in the tank";
        public static string FuelIsNegativeOrZero = "Fuel must be a positive number";
    }
}
