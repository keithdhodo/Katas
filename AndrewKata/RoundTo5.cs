using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewKata
{
    public class RoundTo5
    {
        public static int RoundToNext5(int n)
        {
            while (n % 5 != 0)
            {
                n++;
            }

            return n;
        }
    }
}
