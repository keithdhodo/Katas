using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class LeastDisruptiveSubrange
    {
        public static int[] FindLeastDisruptiveSubrangeIndex(int[] original, int[] replacement)
        {
            // find the smallest number where original[x] is equal to or close to replacement[0]
            for (int i = 0; i < original.Length; i++)
            {
                for (int j = 0; j < replacement.Length; j++)
                {

                }
            }

            return original;
        }
    }
}
