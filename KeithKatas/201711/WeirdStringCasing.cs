namespace Kata.November2017
{
    public class WeirdStringCasing
    {
        public static string ToWeirdCase(string s)
        {
            int counter = 0;
            var charArray = s.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (counter % 2 == 0)
                {
                    charArray[i] = char.ToUpperInvariant(charArray[i]);
                }
                else
                {
                    charArray[i] = char.ToLowerInvariant(charArray[i]);
                }

                if (charArray[i] == ' ')
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }

            return new string(charArray);
        }
    }
}
