using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.June2017
{
    public class PartialWordSearching
    {
        public static string[] WordSearch(string query, string[] seq)
        {
            var strings = seq.Where(st => st.ToLowerInvariant().Contains(query.ToLowerInvariant())).ToArray();
            if (strings.Length == 0)
            {
                strings = new string[1];
                strings[0] = "Empty";
            }
            return strings;
        }
    }
}
