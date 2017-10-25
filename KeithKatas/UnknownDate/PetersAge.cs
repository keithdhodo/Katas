using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class PetersAge
    {
        public static string HowOld(DateTime birthday)
        {
            // Happy coding
            birthday = birthday.Date;
            DateTime now = DateTime.Today.Date;

            var Days = now.Day - birthday.Day;
            if (Days < 0)
            {
                var newNow = now.AddMonths(-1);
                Days += (int)(now - newNow).TotalDays;
                now = newNow;
            }
            var Months = now.Month - birthday.Month;
            if (Months < 0)
            {
                Months += 12;
                now = now.AddYears(-1);
            }
            var Years = now.Year - birthday.Year;

            return string.Format("Peter is {0} years, {1} months and {2} days old", Years, Months, Days);
        }
    }
}
