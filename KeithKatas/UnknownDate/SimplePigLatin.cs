using System.Text;

namespace Kata
{
    public class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            // create new string to return
            StringBuilder returnString = new StringBuilder();

            // split the incoming string on whitespace
            string[] words = str.Split(' ');
            // move the first letter from each string to the last element
            for (int i = 0; i < words.Length; i++)
            {
                // pre-append space if it's not the first word
                if (i > 0){ returnString.Append(" "); }

                StringBuilder sb = new StringBuilder(words[i].Substring(1, words[i].Length -1));
                sb.Append(words[i][0]);
                // add 'ay' to the end of the word
                sb.Append("ay");
                returnString.Append(sb.ToString());
            }

            return returnString.ToString();
        }
    }
}
