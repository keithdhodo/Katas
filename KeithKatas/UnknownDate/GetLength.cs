using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class GetLength
    {
        public int GetObjectLength(dynamic inputObject)
        {
            if (inputObject is ExpandoObject)
            {
                return (int)inputObject.Length;
            }
            else
            {
                return (int)inputObject.GetType().GetProperty("Length").GetValue(inputObject, null);
            }
        }
    }
}
