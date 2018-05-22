using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.May2018
{
    public static class Disemvowel
    {
        private static HashSet<char> vowels = new HashSet<char>("aeiou");

        public static string DisemvowelTrolls(string str)
        {
            var disemvoweled = new string(str.Where(ch => !vowels.Contains(char.ToLowerInvariant(ch))).ToArray());
            return disemvoweled;
        }
    }
}
