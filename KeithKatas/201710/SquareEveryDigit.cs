using System;
using System.Text;

namespace KeithKatas.October2017
{
    public class SquareEveryDigit
    {
        public static int SquareDigits(int input)
        {
            var inputAsCharArray = input.ToString().ToCharArray();
            var sb = new StringBuilder();

            foreach (var character in inputAsCharArray)
            {
                var characterAsInt = int.Parse(character.ToString());
                var valueForAppend = Math.Pow(characterAsInt, 2);
                sb.Append(valueForAppend);
            }

            return int.Parse(sb.ToString());
        }
    }
}
