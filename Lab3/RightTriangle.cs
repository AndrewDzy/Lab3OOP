using System;

namespace TriangleApp
{
    class RightTriangle : Triangle
    {
        public RightTriangle(double s1, double s2, double a) : base(s1, s2, a)
        {
        }

        public override double CalculateArea()
        {
            return 0.5 * side1 * side2;
        }

        public override double CalculatePerimeter()
        {
            double side3 = Math.Sqrt(side1 * side1 + side2 * side2);
            return side1 + side2 + side3;
        }
    }
}
