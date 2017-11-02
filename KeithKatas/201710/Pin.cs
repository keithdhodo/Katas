using System.Text.RegularExpressions;

namespace Kata.October2017
{
    public class Pin
    {
        private static readonly string pinRegex = @"(^[0-9]{4}$)|(^[0-9]{6}$)";

        public static bool ValidatePin(string input)
        {
            return (input.Length == 4 || input.Length == 6) && (Regex.Match(input, pinRegex).Success);
        }
    }
}
