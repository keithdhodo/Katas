namespace Kata
{
    public class Sum
    {
        public int GetSum(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else if (a < b)
            {
                return b += GetSum(a, b - 1);
            }
            else
            {
                return a += GetSum(a - 1, b);
            }
        }
    }
}
