using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeithKatas.August2016
{
    public class PeteSpeak
    {
        static List<string> punctuation = new List<string>() { ".", "!", "?" };
        static List<char> alternatePunctuation = new List<char>() { ',', ';', ':' };

        public static string PeteTalk(string speech, params string[] ok)
        {
            string[] words = speech.Split(' ');
            StringBuilder sb = new StringBuilder();

            bool lastCharWasPunctuation = true;

            for(int i = 0; i < ok.Length; i++)
            {
                ok[i] = ok[i].ToLowerInvariant();
            }

            for (int iterator = 0; iterator < words.Length; iterator++)
            {
                string stringToEvaluate = words[iterator].ToLowerInvariant();
                string lastCharPunctuation = string.Empty;
                string lastCharAlternatePunctuation = string.Empty;

                if (punctuation.Contains(stringToEvaluate[stringToEvaluate.Length - 1].ToString()))
                {
                    lastCharPunctuation = stringToEvaluate[stringToEvaluate.Length - 1].ToString();
                    stringToEvaluate = stringToEvaluate.Substring(0, stringToEvaluate.Length - 1).ToLowerInvariant();
                }

                if (alternatePunctuation.Contains(stringToEvaluate[stringToEvaluate.Length - 1]))
                {
                    lastCharAlternatePunctuation = stringToEvaluate[stringToEvaluate.Length - 1].ToString();
                    stringToEvaluate = stringToEvaluate.Substring(0, stringToEvaluate.Length - 1).ToLowerInvariant();
                }

                if (!ok.Contains(stringToEvaluate.ToLowerInvariant()) && stringToEvaluate.Length > 2)
                {
                    stringToEvaluate = AddAsterisks(stringToEvaluate);
                }

                // capitalize first letter
                if (lastCharWasPunctuation &&
                    stringToEvaluate[0].ToString() != stringToEvaluate[0].ToString().ToUpperInvariant())
                {
                    stringToEvaluate = stringToEvaluate[0].ToString().ToUpperInvariant()
                        + stringToEvaluate.Substring(1, stringToEvaluate.Length - 1).ToLowerInvariant();
                }

                lastCharWasPunctuation = !(string.IsNullOrEmpty(lastCharPunctuation));
                sb.Append(stringToEvaluate + lastCharPunctuation + lastCharAlternatePunctuation);

                if (iterator < words.Length - 1)
                {
                    sb.Append(" ");
                }
            }

            speech = sb.ToString();

            return speech;
        }

        public static string AddAsterisks(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);
            for(int i = 1; i < input.Length - 1; i++)
            {
                sb.Append("*");
            }
            sb.Append(input[input.Length - 1]);
            return sb.ToString();
        }
    }
}
