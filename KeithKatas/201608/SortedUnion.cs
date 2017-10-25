using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.August2016
{
    public class SortedUnion
    {
        public static object[] UniteUnique(object[][] array)
        {
            List<Object> outArray = new List<Object>();
            foreach(object[] objArray in array)
            {
                foreach(object obj in objArray)
                {
                    if(!outArray.Contains(obj))
                    {
                        outArray.Add(obj);
                    }
                }
                
            }
            return outArray.ToArray();
        }
    }
}
