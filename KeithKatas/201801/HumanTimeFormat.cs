using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.January2018
{
    // https://www.codewars.com/kata/human-readable-duration-format/train/csharp
    public class HumanTimeFormat
    {
        public static string FormatDuration(int seconds)
        {
            var calculatedSeconds = seconds % 60;
            var calculatedMinutes = seconds % Math.Pow(60, 20);
            var calculatedHours = seconds % Math.Pow(60, 2) * 24;
            var calculatedDays = seconds % (Math.Pow(60, 2) * Math.Pow(24, 2));
            var calculatedMonths = seconds % (Math.Pow(60, 2) * Math.Pow(24, 2) * 30);
            var calculatedYears = seconds % (Math.Pow(60, 2) * Math.Pow(24, 2) * 30 * 365);

            if (calculatedSeconds == 0 && calculatedMinutes == 0 && calculatedHours == 0 && calculatedDays == 0 && calculatedMonths == 0 && calculatedYears == 0)
            {
                return "now";
            }

            return string.Empty;
        }
    }
}
