using System.Linq;

namespace KeithKatas.January2018
{
    public class Trolls
    {
        private const string vowels = "aeiou";

        public static string Disemvowel(string str)
        {
            return new string(str.Where(c => !vowels.Contains(char.ToLowerInvariant(c))).ToArray());
        }
    }
}
