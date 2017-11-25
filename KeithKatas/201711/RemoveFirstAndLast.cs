namespace Kata.November2017
{
    public class RemoveFirstAndLast
    {
        public static string RemoveCharacters(string input)
        {
            return input.Length > 0 ? input.Substring(1, input.Length - 2) : string.Empty;
        }
    }
}
