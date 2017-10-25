using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class PrintAllNumbersLessThanN
    {
        public string Pattern(int n)
        {
            // Pattern for 5:
            // 54321\n5432\n543\n54\n5
            if (n<1)
            {
                return "";
            }

            if (n == 1)
            {
                return "1";
            }

            else return "\n";
            //else
            //{
                //// build the string
                //return Pattern(n - 1) + Pattern(n - 2);
            //}
        }
    }
}
