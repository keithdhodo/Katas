using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.November2017
{
    public class StrayNumber
    {
        public static int Stray(int[] numbers)
        {
            //return numbers.GroupBy(x => x).Where(g => g.Count() == 1).Select(y => new { Element = y.Key, Counter = y.Count() }).First().Element;
            return numbers.Aggregate((a, b) => a ^ b);
        }
    }
}
