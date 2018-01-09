using System.Linq;

namespace CustomExtensions
{
    public static class StringExtension
    {
        public static string ToAlternatingCase(this string s)
        {
            return new string(s.Select(x => x == char.ToLowerInvariant(x) ? char.ToUpperInvariant(x) : char.ToLowerInvariant(x)).ToArray());
        }
    }
}
