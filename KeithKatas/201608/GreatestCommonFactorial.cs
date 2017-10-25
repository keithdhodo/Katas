using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.August2016
{
    public class GreatestCommonFactorial
    {
        public static int FindGCF(int num1, int num2)
        {
            return num1 == 0 ? num2 : FindGCF(num2 % num1, num1);

            //if (num1 == num2)
            //{
            //    return num1;
            //}

            //List<int> firstFactors = Factor(num1);
            //List<int> secondFactors = Factor(num2);

            //int max = firstFactors.Intersect(secondFactors).Max();

            //return max;
        }

        public static List<int> Factor(int number)
        {
            List<int> factors = new List<int>();
            int max = (int)Math.Sqrt(number);  //round down
            for (int factor = 1; factor <= max; ++factor)
            { //test from 1 to the square root, or the int below it, inclusive.
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    { // Don't add the square root twice!  Thanks Jon
                        factors.Add(number / factor);
                    }
                }
            }
            return factors;
        }
    }
}
