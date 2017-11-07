using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.July2016
{
    public class NumberOfTwos
    {
        public static int TwoCount(int n)
        {
            int count = 0;

            while (n % 2 == 0)
            {
                count++;
                n /= 2;
            }

            return count;
        }
    }
}
