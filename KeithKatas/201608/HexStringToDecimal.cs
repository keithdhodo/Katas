using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.August2016
{
    public class HexStringToDecimal
    {
        public static int HexToDec(string hexString)
        {
            var n = Convert.ToInt32(hexString.Replace("-", ""), 16);
            return hexString.StartsWith("-") ? n * -1 : n;
            //bool isNegative = hexString.Contains("-");
            //hexString = hexString.Replace("x", string.Empty);
            //if (isNegative) hexString = hexString.Replace("-", string.Empty);
            //int result = 0;
            //int.TryParse(hexString, System.Globalization.NumberStyles.HexNumber, null, out result);
            //if (isNegative) result = result * -1;
            //return result;
        }
    }
}
