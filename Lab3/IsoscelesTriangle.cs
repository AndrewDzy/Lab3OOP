using System;

namespace TriangleApp
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double s1, double s2, double a) : base(s1, s2, a)
        {
        }

        public override double CalculateArea()
        {
            double height = side1 * Math.Sin(angle);
            return 0.5 * side2 * height;
        }

        public override double CalculatePerimeter()
        {
            double side3 = Math.Sqrt(side2 * side2 + 2 * side1 * side2 * Math.Cos(angle));
            return 2 * side1 + side3;
        }
    }
}
