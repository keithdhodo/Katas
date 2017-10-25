using System;

namespace InterviewQuestions
{
    public class IsDivisibleByXAndY
    {
        public static Boolean isDivisible(long n, long x, long y)
        {
            return (n % x == 0) && (n % y == 0);
        }
    }
}
