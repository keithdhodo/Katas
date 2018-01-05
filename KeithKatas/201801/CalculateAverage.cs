using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.January2018
{
    public class CalculateAverage
    {
        public static double FindAverage(double[] array)
        {
            return array.Length > 0 ? array.Average() : 0.0;
        }
    }
}
