using System.Collections.Generic;
using System.Linq;

namespace Kata.November2017
{
    public class CroquetClub
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            //var openOrSenior = new List<string>();

            //foreach(var datum in data)
            //{
            //    var age = datum[0];

            //    if(datum[0] >= 55 && datum[1] > 7)
            //    {
            //        openOrSenior.Add("Senior");
            //    }
            //    else
            //    {
            //        openOrSenior.Add("Open");
            //    }
            //}

            //return openOrSenior;

            return data.Select((int[] member) => (member[0] >= 55 && member[1] > 7) ? "Senior" : "Open");
        }
    }
}
