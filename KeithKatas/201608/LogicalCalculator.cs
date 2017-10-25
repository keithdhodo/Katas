using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.August2016
{
    public class LogicalCalculator
    {
        public static bool LogicalCalc(bool[] array, string op)
        {
            if (array.Length == 1)
                return array[0];

            bool retBool = array[0];
            bool currentBool = array[0];

            switch (op.ToLowerInvariant())
            {
                case "and":
                    for (int iterator = 1; iterator < array.Length; iterator++)
                    {
                        currentBool = array[iterator];
                        retBool = retBool && currentBool;
                    }
                    break;
                case "or":
                    for (int iterator = 1; iterator < array.Length; iterator++)
                    {
                        currentBool = array[iterator];
                        retBool = retBool || currentBool;
                    }
                    break;
                case "xor":
                    for (int iterator = 1; iterator < array.Length; iterator++)
                    {
                        currentBool = array[iterator];
                        retBool = retBool ^ currentBool;
                    }
                    break;
            }

            return retBool;
        }
    }
}
