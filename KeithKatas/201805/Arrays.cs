using System.Linq;

namespace KeithKatas.May2018
{

    public class Arrays
    {
        static string alphabet = "abcdefghijklmnopqrstuvwxyz";


        public static string AlphabetPosition(string text)
        {
            //var sb = new StringBuilder();

            //foreach (var alphabetPosition in text.ToLowerInvariant().Where(t => alphabet.Contains(t)).Select(c => alphabet.IndexOf(c) + 1))
            //{
            //    sb.Append($"{alphabetPosition} ");
            //}

            //var finalString = sb.ToString().TrimEnd();
            //return finalString;

            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }

        public static int CountSheep(bool[] sheep)
        {
            var count = sheep.Where(s => s == true).Count();
            return count;
        }
    }
}
