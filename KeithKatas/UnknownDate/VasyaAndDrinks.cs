using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class VasyaAndDrinks
    {
        public static double OrangeFraction(string fractions)
        {
            // given multiple percentages
            // out how much orange juice is in the overall concoction
            string[] fractionsArray = fractions.Split(' ');
            double overallPercentageOrangeJuice = 0.00000;
            double holdingFraction = 0.00000;

            foreach(string fraction in fractionsArray)
            {
                if(double.TryParse(fraction, out holdingFraction))
                {
                    overallPercentageOrangeJuice += holdingFraction;
                }
                else
                {
                    throw new ArgumentException("Argument {0}: is not a valid number.", fraction);
                }
            }

            return Math.Round(overallPercentageOrangeJuice / fractionsArray.Length, 4);
        }
    }
}
