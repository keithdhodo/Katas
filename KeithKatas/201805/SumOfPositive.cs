using System;
using System.Linq;

namespace KeithKatas.May2018
{
    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            return arr.Length > 0 ? arr.Where(x => x > 0).Sum() : 0;
        }
    }
}
