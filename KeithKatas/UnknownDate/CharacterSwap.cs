using System.Linq;
using System.Text;

namespace Kata
{
    public class CharacterSwap
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        /// <summary>
        /// Replace all vowels with the respective position in a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Vowel2Index(string str)
        {
            if (string.IsNullOrEmpty(str)){ return str; }
            else
            {
                StringBuilder sb = new StringBuilder();

                for(int i = 0; i < str.Length; i++)
                {
                    char myChar = str[i].ToString().ToLowerInvariant()[0];
                    if (vowels.Contains(myChar))
                    {
                        sb.Append((i + 1).ToString());
                    }
                    else
                    {
                        sb.Append(str[i]);
                    }
                }

                return sb.ToString();
            }
        }
    }
}
