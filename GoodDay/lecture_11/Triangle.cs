namespace lecture_11
{

    class Triangle : Figure
    {
        public double Basis { get; set; }
        public double Height { get; set; }

        public Triangle(double basis, double height)
        {
            this.Basis = basis;
            this.Height = height;
        }

        public override double Area() { return Basis * Height * 0.5; }
    }
}
