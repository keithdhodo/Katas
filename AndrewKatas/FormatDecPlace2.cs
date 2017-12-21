using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewKata
{
    public class FormatDecPlace2
    {
        public static double Paste(int numberOne, int numberTwo)
        {
            string dbl = numberOne.ToString() + "." + numberTwo.ToString();

            return double.Parse(dbl);
        }
    }
}
