using System.Linq;

namespace KeithKatas.May2018
{

    public class Isogram
    {
        public static bool IsIsogram(string str)
        {
            return str.ToLowerInvariant().Distinct().Count() == str.Length;
        }
    }
}
