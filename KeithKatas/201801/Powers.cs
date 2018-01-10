using System;
using System.Linq;
using System.Numerics;

namespace KeithKatas.January2018
{
    public class Powers
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            return Enumerable.Range(1, n + 1).Select(x => new BigInteger(Math.Pow(2, x - 1))).ToArray();
        }
    }
}
