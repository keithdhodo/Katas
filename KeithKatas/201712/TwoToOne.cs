using System.Linq;

namespace Kata.December2017
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            return new string(string.Concat(s1, s2).Distinct().OrderBy(x => x).ToArray());
        }
    }
}
