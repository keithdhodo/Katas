using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class Slope
    {
        public String slope(int[] points)
        {
            // y2 - y1 / x2 - x1
            string slope = "undefined";

            if (points.Length == 4)
            {
                int yValue = points[3] - points[1];
                int xValue = points[2] - points[0];

                if (xValue != 0)
                {
                    slope = (yValue / xValue).ToString();
                }
            }

            return slope;
        }
    }
}
