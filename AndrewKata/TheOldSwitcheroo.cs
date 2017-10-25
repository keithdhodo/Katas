using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AndrewKata
{
    public class TheOldSwitcheroo
    {
        public static string Vowel2Index(string str)
        {
            StringBuilder strBldr = new StringBuilder();
            int index = 1;

            foreach (char c in str)
            {
                if (Regex.IsMatch(c.ToString(), @"[aeiou]")) strBldr.Append(index.ToString());
                else strBldr.Append(c);

                index += 1;
            }
            return strBldr.ToString();
        }
    }
}
