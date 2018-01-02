using System.Linq;

namespace KeithKatas.January2018
{
    public class SortInnerContent
    {
        public static string SortTheInnerContent(string words)
        {
            // my solution: 
            //var wordsArray = words.Split(' ');

            //for (int i = 0; i < wordsArray.Length; i++ )
            //{
            //    var currentString = wordsArray[i];
            //    currentString = currentString.Length == 1 ? 
            //        currentString :
            //        currentString[0] +
            //        new string(currentString.Skip(1).Take(currentString.Length - 2).OrderByDescending(x => x).ToArray()) +
            //        currentString[currentString.Length - 1];
            //    wordsArray[i] = currentString;
            //}

            //return string.Join(" ", wordsArray);

            // LINQ
            return string.Join(" ", words.Split(' ').Select(x => x.Length < 4 ? x : x.First() + string.Concat(x.Skip(1).Take(x.Length - 2).OrderByDescending(c => c)) + x.Last()));
        }
    }
}
