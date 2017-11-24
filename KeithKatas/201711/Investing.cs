namespace Kata.November2017
{
    public class Investing
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;

            if (desiredPrincipal == principal)
            {
                return years;
            }

            while(principal < desiredPrincipal)
            {
                var earnedInterest = principal * interest;
                var taxToDeduct = tax * earnedInterest;
                principal += earnedInterest - taxToDeduct;
                years++;
            }

            return years;
        }
    }
}
