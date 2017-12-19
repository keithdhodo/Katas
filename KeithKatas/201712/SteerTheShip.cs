using System;

namespace Kata.December2017
{
    public class SteerTheShip
    {
        public static string Steer(double x, double y)
        {
            double angle = Math.Atan2(x, y) * 180 / Math.PI;
            return String.Format("{0}: {1}", (angle >= 0) ? "R" : "L", Math.Abs(angle).ToString("0.##"));
        }
    }
}
