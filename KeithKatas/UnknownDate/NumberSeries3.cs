using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    using System;
    public class Sum
    {
        public int GetSum(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else if (a < b)
            {
                return b += GetSum(a, b - 1);
            }
            else
            {
                return a += GetSum(a - 1, b);
            }
        }
    }
}
