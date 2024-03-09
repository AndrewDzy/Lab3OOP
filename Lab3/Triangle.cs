using System;

namespace TriangleApp
{ 
    abstract class Triangle
    {
        protected double side1;
        protected double side2;
        protected double angle;

        public Triangle(double s1, double s2, double a)
        {
            side1 = s1;
            side2 = s2;
            angle = a;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
