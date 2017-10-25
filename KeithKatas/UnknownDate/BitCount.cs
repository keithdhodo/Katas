using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class BitCount
    {
        public static int CountBits(int n)
        {
            //int remainder;
            //string result = string.Empty;
            //while (n > 0)
            //{
            //    remainder = n % 2;
            //    n /= 2;
            //    result = remainder.ToString() + result;
            //}

            //int resultAsInt = !string.IsNullOrEmpty(result) ? int.Parse(result) : 0;

            int count = 0;

            while (n > 0)
            {
                ++count;
                n = (n - 1) & n;
            }

            return count;
        }
    }
}
