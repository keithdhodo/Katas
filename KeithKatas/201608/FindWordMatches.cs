using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.August2016
{
    public class FindWordMatches
    {
        public static int FindMatchCount(List<string> data, string searchPhrase)
        {
            int count = 0;
            searchPhrase = searchPhrase.ToLowerInvariant();

            foreach (string str in data)
            {
                if (str.ToLowerInvariant().Contains(searchPhrase))
                    count++;
            }

            return count;
        }
    }
}
