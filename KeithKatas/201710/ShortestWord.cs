using System.Linq;

namespace KeithKatas.October2017
{
    public class ShortestWord
    {
        public static int FindShort(string input)
        {
            return input.Split(' ').Min(x => x.Length);
        }
    }
}
