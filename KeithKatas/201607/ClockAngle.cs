using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.July2016
{
    /// <summary>
    /// https://www.codewars.com/kata/clock-angle-problem/train/csharp
    /// </summary>
    public class ClockAngle
    {
        public static int CalculateAngle(int hour, int minute)
        {
            if(hour == 12 && minute == 0)
            {
                return 0;
            }

            int hourAngle = 30 * hour + (int)(.5 * minute);
            int minuteAngle = 6 * minute;

            int angle1 = hourAngle > minuteAngle ? hourAngle - minuteAngle : minuteAngle - hourAngle;
            return angle1 > 180 ? 180 - angle1 : angle1;
        }
    }
}
