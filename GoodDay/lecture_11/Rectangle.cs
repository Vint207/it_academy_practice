using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_11
{
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Area() { return Width * Height; }
    }
}
