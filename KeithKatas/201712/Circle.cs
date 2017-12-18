using System;

namespace Kata.December2017
{
    public class Circle
    {
        public Point Center { get; private set; }
        public double Radius { get; private set; }

        public Circle(Point center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public static double GetArea(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }
    }
}
