using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.November2017
{
    public class ChocolateBar
    {
        public static int BreakChocolate(int n, int m)
        {
            return (n > 0 && m > 0) ? n * m -1 : 0;
        }
    }
}
