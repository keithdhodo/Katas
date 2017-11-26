using System.Linq;

namespace Kata.November2017
{
    public class FakeBinary
    {
        public static string ConvertToFakeBinary(string v)
        {
            //var inputAsCharArray = v.ToCharArray();
            //for(int i = 0; i < inputAsCharArray.Length; i++)
            //{
            //    if (int.Parse(inputAsCharArray[i].ToString()) < 5)
            //    {
            //        inputAsCharArray[i] = '0';
            //    }
            //    else
            //    {
            //        inputAsCharArray[i] = '1';
            //    }
            //}
            //return new string(inputAsCharArray);

            return string.Concat(v.Select(a => a < '5' ? "0" : "1"));
        }
    }
}
