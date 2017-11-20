using System;

namespace Kata.November2017
{
    public class DecibelScale
    {
        public static double DbScale(double intensity)
        {
            return 10 * Math.Log10(intensity / Math.Pow(10, -12));
        }
    }
}
