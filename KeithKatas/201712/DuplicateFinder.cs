using System.Linq;

namespace Kata.December2017
{
    public class DuplicateFinder
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLowerInvariant()
              .GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .Count();
        }
    }
}
