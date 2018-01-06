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
            var ticks = seconds * (long)Math.Pow(10, 7);
            var timespan = new DateTime(ticks);
            var calculatedYearsString = timespan.Year - 1 == 0 ? string.Empty : (timespan.Year - 1 > 1 ? $"{timespan.Year - 1} years" : $"{timespan.Year - 1} year");
            var calculatedMonthsString = timespan.Month - 1 == 0 ? string.Empty : (timespan.Month - 1 > 1 ? $"{timespan.Month} months" : $"{timespan.Month - 1} month");
            var calculatedDays = timespan.Day - 1 == 0 ? string.Empty : (timespan.Day - 1 > 1 ? $"{timespan.Day} days" : $"{timespan.Day - 1} day");
            var calculatedHours = timespan.Hour == 0 ? string.Empty : (timespan.Hour > 1 ? $"{timespan.Hour} hours" : $"{timespan.Hour} hour");
            var calculatedMinutes = timespan.Minute == 0 ? string.Empty : (timespan.Minute > 1 ? $"{timespan.Minute} minutes" : $"{timespan.Minute} minute");
            var calculatedSeconds = timespan.Second == 0 ? string.Empty : (timespan.Second > 1 ? $"{timespan.Second} seconds" : $"{timespan.Second} second");

            var humanReadableString = calculatedYearsString + calculatedMonthsString + calculatedDays + calculatedHours + calculatedMinutes + calculatedSeconds;

            //if (calculatedSeconds == 0 && calculatedMinutes == 0 && calculatedHours == 0 && calculatedDays == 0 && calculatedMonths == 0 && calculatedYears == 0)
            //{
            //    return "now";
            //}

            return string.IsNullOrEmpty(humanReadableString) ? "now" : humanReadableString;
        }
    }
}
