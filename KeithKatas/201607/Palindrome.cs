namespace Kata.July2016
{
    public class Palindrome
    {
        public static bool IsPalindrome(object line)
        {
            if (line == null){ return false; }

            string lineAsString = line.ToString();
            int upperIterator = lineAsString.Length - 1;

            for (int iterator = 0; iterator < lineAsString.Length / 2; iterator++)
            {
                if (lineAsString[iterator].ToString().ToLowerInvariant() != lineAsString[upperIterator].ToString().ToLowerInvariant())
                {
                    return false;
                }

                upperIterator--;
            }

            return true;
        }
    }
}
