using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewKata
{
    public class PetersAge
    {
        public static string HowOld(DateTime birthday)
        {
            DateTime now = DateTime.Now;
            int Years = birthday.Year - now.Year;
            int Months = birthday.Month - now.Month;
            int Days = birthday.Day - now.Day;

            return string.Format("Peter is {0} years, {1} months and {2} days old", Years, Months, Days);
        }
    }
}

/*
Write a method that take Peter's birthday in form of DateTime and return Peter's age in form of String.

The string should be in the following form:

string.Format("Peter is {0} years, {1} months and {2} days old", Years, Months, Days);
for Example suppose you are solving this kata in November 15th, 2015, and Peter's birthday is September 21st, 1983 so the result should be:

"Peter is 32 years, 1 months and 24 days old"
and again suppose you are solving this kata in November 15th, 2015, and Peter's birthday is October 14th, 2014 so the result should be:

"Peter is 1 years, 1 months and 1 days old"
*/
