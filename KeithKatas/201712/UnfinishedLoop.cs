using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.December2017
{
    public class UnfinishedLoop
    {
        public static List<int> CreateList(int number)
        {
            //List<int> list = new List<int>();

            //for (int counter = 1; counter <= number; counter++)
            //{
            //    list.Add(counter);
            //}

            //return list;
            return Enumerable.Range(1, number).ToList();
        }
    }
}
