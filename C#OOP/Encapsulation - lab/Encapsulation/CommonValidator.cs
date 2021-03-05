using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class CommonValidator
    {
        public static void ValidateNull(object value, string name = null)
        {
            if (value == null)
            {
                string message = name == null ? $"Value cannot be null" : "Name cannot be null";

                throw new NullReferenceException();
            }
        }
        public static void ValidateMin(int value, int minimum , string typeName , string properyName)
        {
            if(value < minimum)
            {
                throw new ArgumentOutOfRangeException($"{typeName}.{properyName} cannot be less than minimum");
            }
        }

        public static void ValidateMin(decimal value, int minimum, string typeName,  string properyName)
        {
            if (value < minimum)
            {
                throw new ArgumentOutOfRangeException($"{typeName}.{properyName} cannot be less than minimum");
            }
        }
    }
}
