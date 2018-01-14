using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.January2018
{
    public class Filter
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            return listOfItems.OfType<int>().Cast<int>();
            //return listOfItems
            //        .Where(item => item.GetType() != typeof(string))
            //        .Select(str => {
            //            int value;
            //            bool success = int.TryParse(str.ToString(), out value);
            //            return new { value, success };
            //        })
            //      .Where(pair => pair.success)
            //      .Select(pair => pair.value);
        }
    }
}
