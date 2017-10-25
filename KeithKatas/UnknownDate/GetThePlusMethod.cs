using System;

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
