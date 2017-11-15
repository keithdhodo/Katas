using System.Linq;

namespace Kata.November2017
{

    public class Mathematics
    {
        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();
        }
    }
}
