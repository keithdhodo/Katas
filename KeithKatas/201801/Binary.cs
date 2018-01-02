using System;

namespace KeithKatas.January2018
{
    public class Binary
    {
        public static int BinaryArrayToNumber(int[] binaryArray)
        {
            // my solution 
            var length = binaryArray.Length;
            var number = 0;

            for (int i = length - 1, j = 0; i >= 0; i--, j++)
            {
                if (binaryArray[i] != 0)
                { 
                    number += (int)Math.Pow(2, j);
                }
            }

            return number;

            // LINQ Solution
            // return Convert.ToInt32(string.Join("", binaryArray), 2);
        }
    }
}
