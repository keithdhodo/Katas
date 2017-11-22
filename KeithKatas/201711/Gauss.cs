namespace Kata.November2017
{
    public class Gauss
    {
        public static long? RangeSum(long n)
        {
            // Note: This function's runtime can be made to be near-instant, but it should not be necessary for this Kata.

            // Triangular Number Formula:
            // https://en.wikipedia.org/wiki/Triangular_number
            return n < 1 ? (long?) null : (n) * (n + 1) / 2;

            // return n < 0 ? (long?)null : ExtensionLong.Range(0, n + 1).Sum();

            //if (n < 0)
            //{
            //    return null;
            //}
            //else
            //{
            //    Int64 sum = 0;

            //    for (Int64 i = 0; i <= n; i++)
            //    {
            //        sum += i;
            //    }

            //    return sum;
            //}
        }
    }
}
