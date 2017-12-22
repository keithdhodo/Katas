using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.December2017
{
    public class CountByX
    {
        public static int[] CountBy(int x, int n)
        {
            //var output = new List<int>();

            //for (int i = x, j = 1; j <= n; i += x, j++)
            //{
            //    output.Add(i);
            //}

            //return output.ToArray();

            return Enumerable.Range(1, n).Select(i => i * x).ToArray();
        }
    }
}
