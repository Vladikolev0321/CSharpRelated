using System;
using System.Collections.Generic;
using System.Text;

namespace P01.BoxData
{
    
        public class Box
        {
            private const double SIDE_MIN_VALUE = 0;
            private const string INVALID_SIDE_MESSAGE = "{0} cannot be zero or negative.";

            private double length;
            private double width;
            private double height;

            public Box(double length, double width, double height)
            {
                this.Length = length;
                this.Width = width;
                this.Height = height;
            }

            public double Length
            {
                get
                {
                    return this.length;
                }
                private set
                {
                    ValidateSide(value, nameof(this.Length));
                    this.length = value;
                }
            }

            public double Width
            {
                get
                {
                    return this.width;
                }
                private set
                {
                    ValidateSide(value, nameof(this.Width));

                    this.width = value;
                }
            }
            public double Height
            {
                get
                {
                    return this.height;
                }
                private set
                {
                    ValidateSide(value, nameof(this.Height));
                    this.height = value;
                }
            }

            public double CalculateSurfaceArea()
            {
                double surfaceArea = (2 * this.Length * this.Width) + (2 * this.Length * this.Height)
                    + (2 * this.Width * this.Height);
                return surfaceArea;
            }
            public double CalculateLateralSurfaceArea()
            {
                double lateralSurfaceArea = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
                return lateralSurfaceArea;
            }
            public double CalculateVolume()
            {
                double volume = this.Length * this.Height * this.Width;
                return volume;
            }
            private void ValidateSide(double value, string sideName)
            {
                if (value <= SIDE_MIN_VALUE)
                {
                    throw new ArgumentException(string.Format
                    (INVALID_SIDE_MESSAGE, sideName));
                }
            }
        }
}
