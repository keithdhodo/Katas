using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.July2016
{
    public class DistancesFromAvg
    {
        public static double[] DistancesFromAverage(int[] input)
        {
            if (input == null) { return new double[0]; }

            decimal average = ((decimal)input.Sum() / (decimal)input.Length);
            average = decimal.Round(average, 1);
            List<double> distances = new List<double>();
            foreach(int number in input)
            {
                distances.Add((double)((number - average) * -1));
            }
            return distances.ToArray();
        }
    }
}
