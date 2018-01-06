using System.Linq;

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
