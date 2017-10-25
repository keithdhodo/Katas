namespace Kata.October2017
{
    // http://www.codewars.com/kata/584acbee7d22f84dc80000e2/
    public class ImproperFraction
    {
        public static string GetMixedNumber(string fraction)
        {
            var split = fraction.Split('/');
            var numerator = int.Parse(split[0]);
            var denominator = int.Parse(split[1]);

            int wholeNumber = numerator / denominator;
            var numeratorForReturn = numerator % denominator;
            return $"{wholeNumber} {numeratorForReturn}/{denominator}";
        }
    }
}
