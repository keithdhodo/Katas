namespace Kata.November2017
{
    public class LargestFiveDigitSequence
    {
        public static int GetNumber(string str)
        {
            int largestValue = 0;

            if (str.Length < 5)
            {
                int.TryParse(str, out largestValue);
                return largestValue;
            }

            for (int i = 0; i < str.Length - 4; i++)
            {
                int valueToCompare = 0;
                int.TryParse(str.Substring(i, 5), out valueToCompare);
                
                if (valueToCompare > largestValue)
                {
                    largestValue = valueToCompare;
                }
            }

            return largestValue;
        }
    }
}
