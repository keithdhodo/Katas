using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.August2016
{
    /// <summary>
    /// https://www.codewars.com/kata/55b3425df71c1201a800009c/train/csharp
    /// 
    /// To compare the results of the teams you are asked for giving three statistics; range, average and median.
    ///Range : difference between the lowest and highest values.In {4, 6, 9, 3, 7}
    ///the lowest value is 3, and the highest is 9, so the range is 9 − 3 = 6.
    ///
    ///Mean or Average : To calculate mean, add together all of the numbers in a set and then divide the sum by the total count of numbers.
    ///
    ///Median : In statistics, the median is the number separating the higher half of a data sample from the lower half.The median of a finite list of numbers can be found by arranging all the observations from lowest value to highest value and picking the middle one (e.g., the median of { 3, 3, 5, 9, 11} is 5) when there is an odd number of observations.If there is an even number of observations, then there is no single middle value; the median is then defined to be the mean of the two middle values(the median of { 3, 5, 6, 9} is (5 + 6) / 2 = 5.5).
    ///
    ///Your task is to return a string giving these 3 values.For the example given above, the string result will be
    ///
    ///"Range: 00|47|18 Average: 01|35|15 Median: 01|32|34"
    ///
    ///of the form:
    ///
    ///"Range: hh|mm|ss Average: hh|mm|ss Median: hh|mm|ss"
    ///
    ///where hh, mm, ss are integers(represented by strings) with each 2 digits.
    ///
    ///Remarks:
    ///
    ///if a result in seconds is ab.xy...it will be given truncated as ab.
    ///if the given string is "" you will return ""
    /// </summary>
    public class Stat
    {
        public static string GetStats(string strg)
        {
            // 01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17
            string[] firstSplit = strg.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            List<TimeSpan> ts = new List<TimeSpan>();

            TimeSpan mean = new TimeSpan();

            for (int iterator = 0; iterator < firstSplit.Length; iterator++)
            {
                string[] secondSplit = firstSplit[iterator].Split('|');
                TimeSpan time = new TimeSpan(int.Parse(secondSplit[0]), int.Parse(secondSplit[1]), int.Parse(secondSplit[2]));
                mean += time;
                ts.Add(time);
            }
            ts.Sort();
            StringBuilder sb = new StringBuilder();
            TimeSpan range = new TimeSpan();
            range = ts[ts.Count - 1] - ts[0];
            sb.Append(WriteText("Range", range.Hours, range.Minutes, range.Seconds, true));
            mean = new TimeSpan(mean.Hours / ts.Count, mean.Minutes / ts.Count, Math.Abs(mean.Minutes / ts.Count));
            sb.Append(WriteText("Average", mean.Hours, mean.Minutes, mean.Seconds, true));
            TimeSpan median = new TimeSpan();
            if (ts.Count % 2 == 0)
            {
                median = ts[ts.Count / 2] + ts[ts.Count / 2 - 1];
                median = new TimeSpan(median.Hours / 2, median.Minutes / 2, Math.Abs(median.Minutes / 2));
            }
            else
            {
                median = ts[ts.Count / 2 - 1];
            }
            sb.Append(WriteText("Median", median.Hours, median.Minutes, median.Seconds, true));

            string retString = sb.ToString();

            // Range: 01|01|18 Average: 01|38|05 Median: 01|32|34
            return retString;
        }

        public static string WriteText(string statType, int hours, int minutes, int seconds, bool appendSpace)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(statType);
            sb.Append(": ");
            if (hours / 10 < 1) { sb.Append("0" + hours); } else { sb.Append(hours); }
            sb.Append("|");
            if (minutes / 10 < 1) { sb.Append("0" + minutes); } else { sb.Append(minutes); }
            sb.Append("|");
            if (seconds / 10 < 1) { sb.Append("0" + seconds); } else { sb.Append(seconds); }
            if (appendSpace) sb.Append(" ");
            return sb.ToString();
        }
    }
}
