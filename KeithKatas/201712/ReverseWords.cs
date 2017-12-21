using System.Linq;

namespace Kata.December2017
{
    public class ReverseWords
    {
        public static string Reverse(string str)
        {
            return string.Join(" ", str.Split(' ').Reverse());
        }
    }
}
