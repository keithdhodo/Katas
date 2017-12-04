using System;
using System.Linq;

namespace Kata.December2017
{
    public class Addition
    {
        public static int Sum(int[] numbers)
        {
            if(numbers == null || numbers.Length <= 1)
            {
                return 0;
            }

            Array.Sort(numbers);
            return numbers.Skip(1).Take(numbers.Length - 2).Sum();
        }
    }
}
