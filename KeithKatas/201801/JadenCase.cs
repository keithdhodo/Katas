using System.Threading;

namespace KeithKatas.January2018
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            var jadenCase = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(phrase);
            return jadenCase;
        }
    }
}
