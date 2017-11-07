using System;

// https://www.codewars.com/kata/formatting-decimal-places-number-1/train/csharp

namespace KeithKatas.July2017
{
    public class DecimalPlaces
    {
        public static double TwoDecimalPlaces(double number)
        {
            return Math.Truncate(100 * number) / 100;
        }
    }
}
