using System;
using System.Collections.Generic;


namespace Kata.August2016
{
    public class Xbonacci
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            if (signature == null) return null;
            if (n == 0)
            {
                return new double[1] { 0.0 };
            }
            if (n == 1)
            {
                return new double[1] { signature[0] };
            }
            if (n == 2)
            {
                return new double[2] { signature[0], signature[1] };
            }
            if (n == 3)
            {
                return new double[3] { signature[0], signature[1], signature[2] };
            }

            var returnValues = new List<double>();
            double firstNumber = signature[0];
            double secondNumber = signature[1];
            double thirdNumber = signature[2];
            returnValues.Add(firstNumber);
            returnValues.Add(secondNumber);
            returnValues.Add(thirdNumber);

            for(int iterator = 3; iterator < n; iterator++)
            {
                double newNumber = firstNumber + secondNumber + thirdNumber;
                returnValues.Add(newNumber);

                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = newNumber;
            }

            return returnValues.ToArray();
        }
    }
}
