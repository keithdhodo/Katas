using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class DivisibleByFour
    {
        public static bool IsDivisibleByFour(int n)
        {
            // http://www.codewars.com/kata/55d3220150becbdb150000c1/train
            return n % 4 == 0;
        }
    }
}
