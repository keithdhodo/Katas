using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.January2018
{
    public class StringDuplicate
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLowerInvariant();

            var characters = word.GroupBy(c => c)
                  .Select(g => new KeyValuePair<char, int>(g.Key, g.Count())).ToDictionary(x => x.Key, x => x.Value);

            var encodedWord = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                if (characters[word[i]] > 1)
                {
                    encodedWord[i] = ')';
                }
                else
                {
                    encodedWord[i] = '(';
                }
            }

            return new string(encodedWord);
        }
    }
}
