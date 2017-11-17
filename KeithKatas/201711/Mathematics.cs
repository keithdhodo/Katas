using System;
using System.Linq;

namespace Kata.November2017
{

    public class Mathematics
    {
        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();
        }

        public static int Factorial(int n)
        {
            if(n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException();
            }

            var factorial = 1;

            for(int i = n; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
