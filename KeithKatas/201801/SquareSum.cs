using System;
using System.Linq;

namespace KeithKatas.January2018
{
    public class SquareSum
    {
        public static int SquareAndSum(int[] n)
        {
            return n.Select(x => (int)Math.Pow(x, 2)).Sum();
        }
    }
}
