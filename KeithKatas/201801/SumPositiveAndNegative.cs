using System.Linq;

namespace KeithKatas.January2018
{
    public class SumPositiveAndNegative
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return new int[] { };
            }

            return new int[]
            {
                input.Where(x => x > 0).Count(),
                input.Where(x => x < 0).Sum()
            };
        }
    }
}
