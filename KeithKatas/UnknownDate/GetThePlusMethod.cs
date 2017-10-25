using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class GetThePlusMethod
    {
        public static Func<int, int> MethodFunc(int i)
        {
            return x => x + i;
        }
    }
}
