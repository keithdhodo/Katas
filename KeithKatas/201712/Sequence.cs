namespace KeithKatas.December2017
{
    public class Sequence
    {
        public static int SequenceSum(int start, int end, int step)
        {
            int sum = 0;
            for (int i = start; i <= end; i += step)
            {
                sum += i;
            }
            return sum;
        }
    }
}
