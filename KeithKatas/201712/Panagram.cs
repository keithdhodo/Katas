using System.Collections.Generic;
using System.Linq;

namespace Kata.December2017
{
    public class Panagram
    {
        public readonly static IEnumerable<char> EnglishAlphabet = "abcdefghijklmnopqrstuvwxyz";

        public static bool CheckForPanagram(string str)
        {
            if (str.Length < EnglishAlphabet.Count())
            {
                return false;
            }

            HashSet<char> lettersInInputString = new HashSet<char>(str);
            return lettersInInputString.Count() >= EnglishAlphabet.Count();
        }
    }
}
