using System.Collections.Generic;

// https://www.codewars.com/kata/tribonacci-sequence/train/csharp
namespace Kata.June2017
{
    public class Tribonacci
    {
        public double[] GetNFromSequence(double[] signature, int n)
        {
            var list = new List<double>(signature);

            // hackonacci me
            // if n==0, then return an array of length 1, containing only a 0
            if (n == 0)
            {
                return new double[1] { 0 };
            }
            else if (n == 1)
            {
                return new double[1] { signature[0] };
            }
            else if (n == 2)
            {
                return new double[2] { signature[0], signature[1] };
            }
            else if (n == 3)
            {
                return signature;
            }

            int start = 3;
            double nMinusOne = list[start - 1];
            double nMinusTwo = list[start - 2];
            double nMinusThree = list[start - 3];

            for (int i = 3; i < n; i++)
            {
                list.Add(nMinusOne + nMinusTwo + nMinusThree);
                nMinusOne = list[i];
                nMinusTwo = list[i - 1];
                nMinusThree = list[i - 2];
            }

            return list.ToArray();
        }
    }
}
