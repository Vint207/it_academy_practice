using System;

namespace lecture_11
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius) { this.Radius = radius; }

        public override double Area() { return Math.PI * Math.Pow(Radius, 2); }
    }
}
