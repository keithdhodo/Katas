using System.Collections.Generic;
using System.Linq;

namespace Kata.December2017
{
    public class PhoneNumber
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            var areaCode = IntegerArrayToString(numbers.Take(3));
            var prefix = IntegerArrayToString(numbers.Skip(3).Take(3));
            var suffix = IntegerArrayToString(numbers.Skip(6).Take(4));

            return $"({areaCode}) {prefix}-{suffix}";
        }

		public static string IntegerArrayToString(IEnumerable<int> input)
        {
            return new string(input.Select(x => char.Parse(x.ToString())).ToArray());
        }
    }
}