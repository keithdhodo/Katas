using System.Linq;

namespace Kata.December2017
{
    public class AlternateSort
    {
        public static string[] SortByZ(string[] g, int z)
        {
            return g.OrderBy(word => word.ToLower()[z - 1]).ToArray();
        }
    }
}
