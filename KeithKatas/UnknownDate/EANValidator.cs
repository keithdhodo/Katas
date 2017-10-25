using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class EANValidator
    {
        private readonly static int checkSumPosition = 12;

        public static bool Validate(string eanCode)
        {
            bool isValid = false;

            int total = 0;

            for (int i = 0; i < eanCode.Length - 1; i++)
            {
                int hold = 0;
                int.TryParse(eanCode[i].ToString(), out hold);

                total += i % 2 == 0 ? (hold * 1) : (hold * 3);
            }

            int calculatedCheckSum = (total % 10) == 0 ? 0 : 10 - (total % 10);
            int actualCheckSum = 0;
            int.TryParse(eanCode[checkSumPosition].ToString(), out actualCheckSum);

            isValid = actualCheckSum == calculatedCheckSum;

            return isValid;
        }
    }
}
