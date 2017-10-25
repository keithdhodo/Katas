using System.Linq;

namespace InterviewQuestions
{
    public class RuleOfDivisibilityBySeven
    {
        public static long[] Seven(long m)
        {
            // multiply final digit by two and subtract from remaining digits --> if remainder is two digits then divide by seven
            if (m > 100)
            {
                decimal holdingNumber = m / 10;
                int decimalPlace = int.Parse(holdingNumber.ToString().Split('.').Last());
            }

            return new long[2];
        }
    }
}
