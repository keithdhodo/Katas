using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class PyramidSlideDown
    {
        /// <summary>
        /// Returns the path down the Pyramid with the highest value
        /// </summary>
        /// <param name="pyramid">Integer array comprising pyramid</param>
        /// <returns>Value of the longest slide</returns>
        public static int LongestSlideDown(int[][] pyramid)
        {
            for (int row = pyramid.Length - 1; row >= 0; row--)
            {
                for (int oolumn = 0; oolumn < pyramid[row].Length - 1; oolumn++)
                {
                    pyramid[row - 1][oolumn] += Math.Max(pyramid[row][oolumn], pyramid[row][oolumn + 1]);
                }
            }

            int total = pyramid[0][0];
            return total;

            //int total = 0;
            //int index = 0;

            //if (pyramid.Length == 1)
            //{
            //    total = pyramid[0][0];
            //}
            //else
            //{
            //    total += pyramid[0][0];

            //    for (int row = 1; row < pyramid.Length; row++)
            //    {
            //        int left = pyramid[row][index];
            //        int right = pyramid[row][index + 1];

            //        if (left > right)
            //        {
            //            total += left;
            //        }
            //        else // left < right
            //        {
            //            total += right;
            //            index += 1; 
            //        }
            //    }
            //}

            //return total;
        }
    }
}
