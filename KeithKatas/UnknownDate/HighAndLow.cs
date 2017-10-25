using System;
using System.Linq;

namespace Kata
{
    public class HighAndLow
    {
        /*
            In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

            Example:

            Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
            Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
            Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
            Notes:

            All numbers are valid Int32, no need to validate them.
            There will always be at least one number in the input string.
            Output string must be two numbers separated by a single space, and highest number is first.
        */

        public static string HighAndLowNumbers(string numbers)
        {

            var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
            return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());

            //string[] numbersSplit = numbers.Split(' ');
            //int[] nums = numbersSplit.Select(x => int.Parse(x.ToString())).OrderBy(i => i).ToArray();
            //return string.Format("{0} {1}", nums[nums.Length - 1], nums[0]);
        }
    }
}
