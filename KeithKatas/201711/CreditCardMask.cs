using System.Text;

namespace Kata.November2017
{
    public class CreditCardMask
    {
        public static string Maskify(string input)
        {
            return input.Substring(input.Length < 4 ? 0 : input.Length - 4).PadLeft(input.Length, '#');
        }
    }
}
