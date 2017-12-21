using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewKata
{
    class FindSimInLists
    {
        public static string AnySimilarity(List<int> firstList, List<int> secondList, int n)
        {
            int pair = 0;
            List<char> matchNums = new List<char>();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {

                    }
                }
            }

            return pair.ToString();
        }
    }
}
