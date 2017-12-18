using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.December2017
{
    public class Raul
    {
        /// <summary>
        /// return value: array [] of string-Lists
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public static List<string>[] SeparateKeywords(string[] keywords)
        {
            var cSharpWords = new List<string>();
            var footballWords = new List<string>();

            foreach(var word in keywords)
            {
                if (KeywordDictionary.ContainsKey(word))
                {
                    var isFootball = KeywordDictionary[word].ToLowerInvariant() == "football";

                    if (isFootball)
                    {
                        footballWords.Add(word);
                    }
                    else
                    {
                        cSharpWords.Add(word);
                    }
                }
            }

            cSharpWords.Sort();
            footballWords.Sort();

            return new List<string>[2] { cSharpWords, footballWords };
        }

        public static Dictionary<string, string> KeywordDictionary = new Dictionary<string, string>
        {
            { "abstract", "C#" },
            { "as", "C#" },
            { "if", "C#" },
            { "finally", "C#" },
            { "class", "C#" },
            { "namespace", "C#" },
            { "null", "C#" },
            { "public", "C#" },
            { "goal", "football" },
            { "team", "football" },
            { "trainer", "football" }
        };
    }
}
