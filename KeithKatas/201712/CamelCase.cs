using System.Text;

namespace Kata.December2017
{
    public class CamelCase
    {
        public static string ToCamelCase(string str)
        {
            var sb = new StringBuilder();
            var lastCharacterIsSeperator = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && lastCharacterIsSeperator)
                {
                    sb.Append(char.ToUpperInvariant(str[i]));
                    lastCharacterIsSeperator = false;
                }
                else if (char.IsLetter(str[i]))
                {
                    sb.Append(char.ToLowerInvariant(str[i]));
                }
                else
                {
                    lastCharacterIsSeperator = true;
                }
            }

            return sb.ToString();
        }
    }
}
