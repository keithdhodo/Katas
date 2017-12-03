using System.Linq;

namespace Kata.December2017
{
    public class ArraySort
    {
        public static string IsSortedAndHow(int[] array)
        {
            //         bool isAscending = true;
            //         bool isDescending = true;

            //         int lastValue = int.MinValue;

            //for (int i = 0; i < array.Length; i++)
            //         {
            //	if (lastValue < array[i] && i > 0)
            //             {
            //                 isDescending = false;

            //		if (!isAscending)
            //                 {
            //                     return "no";
            //                 }
            //             }
            //	else if (lastValue > array[i] && i > 0)
            //             {
            //                 isAscending = false;

            //                 if (!isDescending)
            //                 {
            //                     return "no";
            //                 }
            //             }

            //             lastValue = array[i];
            //         }

            //         return isAscending ? "yes, ascending" : "yes, descending";
            if (array.OrderBy(a => a).SequenceEqual(array)) return "yes, ascending";
            if (array.OrderByDescending(a => a).SequenceEqual(array)) return "yes, descending";
            return "no";
        }
    }
}