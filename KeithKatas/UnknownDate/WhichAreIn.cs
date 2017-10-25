using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class WhichAreIn
    {
        public static string[] InArray(string[] array1, string[] array2)
        {
            List<string> matches = new List<string>();

            foreach(string str in array1)
            {
                if (array2.Any(s => s.Contains(str)))
                {
                    matches.Add(str);
                }
            }

            string[] debug = matches.OrderBy(x => x).ToArray();

            return debug;
        }
    }
}
