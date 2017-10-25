using System.Linq;

namespace Kata.June2017
{
    public class VowelCount
    {
        public static char[] vowels = {'a', 'e', 'i', 'o', 'u' };

        public static int GetVowelCount(string str)
        {
            return str.Where(st => vowels.Contains(st)).Count();
        }
    }
}
