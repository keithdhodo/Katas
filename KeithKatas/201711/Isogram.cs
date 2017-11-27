using System.Linq;

namespace Kata.November2017
{
    public class Isogram
    {
        public static bool IsIsogram(string str)
        {
            //var isogram = new Dictionary<char, bool>();
            //str = str.ToLowerInvariant();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    char current = str[i];
            //    if (!isogram.ContainsKey(current))
            //    {
            //        isogram.Add(current, true);
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //return true;
            return str.ToLowerInvariant().Distinct().Count() == str.Length;
        }
    }
}
