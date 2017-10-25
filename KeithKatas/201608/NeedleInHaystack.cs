using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.August2016
{
    public class NeedleInHaystack
    {
        public static string FindNeedle(object[] haystack)
        {
            string strToFind = "needle";

            if (haystack == null)
            {
                return string.Empty;
            }
            else
            {
                for(int iterator = 0; iterator < haystack.Length; iterator++)
                {
                    if (haystack[iterator] != null && haystack[iterator].ToString().ToLowerInvariant() == strToFind.ToLowerInvariant())
                    {
                        return "found the needle at position " + iterator.ToString();
                    }
                }
            }

            return string.Empty;
        }
    }
}
