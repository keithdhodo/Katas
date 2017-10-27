using System;

namespace Kata.October2017
{
    public class SequenceSum
    {
        public static int[] SumOfN(int n)
        {
            var iterations = (int)Math.Sqrt(Math.Pow(n, 2));
            var sumOfN = new int[iterations + 1];
            var sum = 0;
            var isPositive = n > -1;

            for (int i = 0; i <= iterations; i++)
            {
                sum = isPositive ? sum + i : sum - i;
                sumOfN[i] = sum;
            }

            return sumOfN;
        }
    }
}
