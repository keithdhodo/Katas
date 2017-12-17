using System;

namespace Kata.December2017
{
    public class SquareOrSquareRoot
    {
        public static int[] SquareSquareRoot(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Sqrt(array[i]) % 1 == 0)
                {
                    array[i] = (int)Math.Sqrt(array[i]);
                }
                else
                {
                    array[i] = (int)Math.Pow(array[i], 2);
                }
            }

            return array;
        }
    }
}
