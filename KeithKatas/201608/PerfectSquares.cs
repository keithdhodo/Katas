using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.August2016
{
    public class PerfectSquares
    {
        public static bool IsSquare(int n)
        {
            if (n < 1)
            {
                return false;
            }
            else
            {
                int absoluteOfSquareRoot = (int)Math.Abs(Math.Sqrt(n));
                return absoluteOfSquareRoot * absoluteOfSquareRoot == n;
            }
        }
    }
}
