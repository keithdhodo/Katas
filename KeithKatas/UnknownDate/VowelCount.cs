using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class VowelCount
    {
        /// <summary>
        /// Return the number (count) of vowels in the given string.
        ///We will consider a, e, i, o, and u as vowels for this Kata.
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
