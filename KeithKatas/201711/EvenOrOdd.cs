namespace Kata.November2017
{
    public class EvenOrOdd
    {
        /// Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
        public static string GetEvenOrOdd(int value)
        {
            return value % 2 == 0 ? "Even" : "Odd";
        }
    }
}
