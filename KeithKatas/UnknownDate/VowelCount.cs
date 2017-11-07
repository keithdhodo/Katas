using System.Linq;

namespace Kata
{
    public class VowelCount
    {
        /// <summary>
        /// Return the number (count) of vowels in the given string.
        ///We will consider a, e, i, o, and u as vowels for this KeithKatas.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int GetVowelCount(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            int vowelCount = 0;

            foreach(char letter in str)
            {
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
