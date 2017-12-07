using System.Linq;

namespace Kata.December2017
{
    public class InvertValue
    {
        public static int[] InvertValues(int[] input)
        {
            return input.Select(n => -n).ToArray();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    input[i] = input[i] * -1;
            //}

            //return input;
        }
    }
}
