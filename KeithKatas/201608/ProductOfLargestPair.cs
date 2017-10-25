using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.August2016
{
    public class ProductOfLargestPair
    {
        public static int MaxProduct(int[] array)
        {
            //Dictionary<int, int> sorted = Enumerable.Range(0, array.Length)
            //               .ToDictionary(x => array[x], x => array[x]);
            //sorted.OrderBy(x => x);

            //return sorted[sorted.Keys.ToList()[sorted.Count - 1]] * sorted[sorted.Keys.ToList()[sorted.Count - 2]];// maxVal * secondMax;
            int secondLargest = array[0];
            int largest = array[0];
            foreach (int value in array)
            {
                if (value > largest)
                {
                    secondLargest = largest;
                    largest = value;
                }
                else if (value > secondLargest)
                {
                    secondLargest = value;
                }
            }

            return secondLargest * largest;
        }
    }
}
