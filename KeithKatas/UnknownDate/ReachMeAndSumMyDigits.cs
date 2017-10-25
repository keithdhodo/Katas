namespace Kata
{
    /// <summary>
    /// https://www.codewars.com/kata/reach-me-and-sum-my-digits/train/csharp
    /// </summary>
    public class ReachMeAndSumMyDigits
    {
        public static long SumDigNthTerm(long initval, long[] patternl, int nthterm)
        {
            long total = initval;

            // add the numbers using the array
            for (int i = 0; i < nthterm - 1; i++)
            {
                total += patternl[(i % patternl.Length)];
            }

            // add up the individual numbers
            //string totalAsString = total.ToString();
            //int newTotal = 0;
            //for (int i = 0; i < totalAsString.ToString().Length; i++)
            //{
            //    newTotal += int.Parse(totalAsString[i].ToString());
            //}

            // add up the individual numbers
            long sum = 0;

            while (total != 0)
            {
                sum += total % 10;
                total /= 10;
            }

            return sum;
        }
    }
}
