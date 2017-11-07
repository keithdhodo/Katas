using System.Linq;

// https://www.codewars.com/kata/count-all-the-sheep-on-farm-in-the-heights-of-new-zealand/train/csharp

namespace KeithKatas.June2017
{
    public class CountingSheep
    {
        public int LostSheep(int[] friday, int[] saturday, int total)
        {
            return total - friday.Sum() - saturday.Sum();
        }
    }
}
