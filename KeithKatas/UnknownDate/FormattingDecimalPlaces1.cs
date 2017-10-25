using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class FormattingDecimalPlaces1
    {
        public static double TwoDecimalPlaces(double number)
        {
            // doesn't work correctly but was the first go...
            //string[] numberAsArray = Math.Round(number, 3).ToString().Split('.');
            //string numberAsString = numberAsArray[0] + '.' + ((numberAsArray[1].Length > 2) ? numberAsArray[1].Remove(2) : numberAsArray[1]);
            //return double.Parse(numberAsString);

            return Math.Truncate(100 * number) / 100;
        }
    }
}
