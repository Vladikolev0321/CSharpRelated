using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public bool Contains(Point point)
        {
            return point.X > this.TopLeft.X && point.X < this.BottomRight.X
                && this.BottomRight.Y<point.Y && point.Y < this.TopLeft.Y;
        }
    }
}
