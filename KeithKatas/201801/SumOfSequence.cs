using System.Text;

namespace KeithKatas.January2018
{
    public class SumOfSequence
    {
        public static string ShowSequence(int n)
        {
            if (n < 0)
            {
                return $"{n}<0";
            }
            else if (n == 0)
            {
                return $"{n}={n}";
            }

            var sb = new StringBuilder();
            var total = 0;

            for (int i = 0; i < n; i++)
            {
                sb.Append($"{i}+");
                total += i;
            }

            sb.Append($"{n} = {total += n}");

            return sb.ToString();
        }
    }
}
