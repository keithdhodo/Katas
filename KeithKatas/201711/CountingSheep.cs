using System.Linq;

namespace Kata.November2017
{
    public class CountingSheep
    {
        public static int CountSheep(bool[] sheeps)
        {
            return sheeps.Where(x => x.Equals(true)).Count();
        }
    }
}
