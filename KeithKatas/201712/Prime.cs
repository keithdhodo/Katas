using System;

namespace KeithKatas.December2017
{
    public class Prime
    {
        public static bool IsPrime(int n)
        {
            if (n >= -2 && n < 2)
            {
                return false;
            }
            else
            {
                var iterations = n > 0 ? (int)Math.Sqrt(n) + 1 : (int)Math.Sqrt(n) - 1;

                for (int i = 2; i < iterations; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
