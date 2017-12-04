using System;

namespace Kata.December2017
{
    public class Clock
    {
        private const int milli = 1000;

        public static double Past(int h, int m, int s)
        {
            int seconds = s * milli;
            int minutes = m * (milli * 60);
            int hours = h * (milli * (int) Math.Pow(60, 2));

            return hours + minutes + seconds;
        }
    }
}
