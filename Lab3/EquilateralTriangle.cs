using System;

namespace TriangleApp
{

    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double s, double a) : base(s, s, a)
        {
        }

        public override double CalculateArea()
        {
            return (Math.Sqrt(3) / 4) * side1 * side1;
        }

        public override double CalculatePerimeter()
        {
            return 3 * side1;
        }
    }
}
