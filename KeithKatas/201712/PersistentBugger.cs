using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.December2017
{
    public class PersistentBugger
    {
        public static int Persistence(long n)
        {
            var inputAsArray = n.ToString().ToCharArray().Select(num => int.Parse(num.ToString()));
            var loopCounter = 0;

            while (inputAsArray.Count() > 1)
            {
                var inputMultiplied = inputAsArray.Aggregate(1, (a, b) => a * b);
                inputAsArray = inputMultiplied.ToString().ToCharArray().Select(num => int.Parse(num.ToString()));
                loopCounter++;
            }

            return loopCounter;
        }
    }
}
