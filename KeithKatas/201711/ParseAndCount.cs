using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.November2017
{
    public class ParseAndCount
    {
        public static int PaC(string str)
        {
            var number = 0;
            var numbers = str.Split(':')[1];

            if (numbers.Contains("+"))
            {
                var numbersAsArray = ConvertToInt(numbers, '+');
                number = numbersAsArray[0] + numbersAsArray[1];
            }
            else if (numbers.Contains("-"))
            {
                var numbersAsArray = ConvertToInt(numbers, '-');
                number = numbersAsArray[0] - numbersAsArray[1];
            }
            else
            {
                int.TryParse(numbers, out number);
            }

            return number;
        }

        private static int[] ConvertToInt(string numbers, char operation)
        {
            var integerList = new List<int>();

            int leftNumber = 0;
            int.TryParse(numbers.Split(operation)[0], out leftNumber);
            integerList.Add(leftNumber);
            int rightNumber = 0;
            int.TryParse(numbers.Split(operation)[1], out rightNumber);
            integerList.Add(rightNumber);
            return integerList.ToArray();
        }
    }
}
