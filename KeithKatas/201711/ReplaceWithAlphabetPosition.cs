using System.Linq;

namespace Kata.November2017
{
    public class ReplaceWithAlphabetPosition
    {
        //private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        //public static string AlphabetPosition(string text)
        //{
        //    text = text.ToUpperInvariant();

        //    var sb = new StringBuilder();

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        var indexOfChar = alphabet.IndexOf(text[i]);

        //        if (indexOfChar > -1)
        //        {
        //            if ((sb.Length > 0) && (i > 0))
        //            {
        //                sb.Append(" ");
        //            }

        //            sb.Append(indexOfChar + 1);
        //        }
        //    }

        //    return sb.ToString();
        //}

        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
    }
}
