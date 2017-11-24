using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class InvestingTests
    {
        [TestCase]
        public void InvestingTests_CalculateYears_GetNumberOfYears0()
        {
            Assert.AreEqual(0, Investing.CalculateYears(1000, 0.05, 0.18, 1000));
        }

        [TestCase]
        public void InvestingTests_CalculateYears_GetNumberOfYears1()
        {
            Assert.AreEqual(14, Investing.CalculateYears(1000, 0.01625, 0.18, 1200));
        }

        [TestCase]
        public void InvestingTests_CalculateYears_GetNumberOfYears3()
        {
            Assert.AreEqual(0, Investing.CalculateYears(1000, 0.05, 0.18, 1000));
        }

        [Test]
        public static void InvestingTests_CalculateYears_RandomTest([Random(1, 10, 98)]int x)
        {
            Random r = new Random();
            double principal = (r.NextDouble() * 10000);

            //double interest = (0.05);
            double interest = (r.NextDouble() * 1);

            //double tax = (0.18);
            double tax = (r.NextDouble() * 0.21);

            //double desiredPrincipal = principal + 100;
            double desiredPrincipal = (r.NextDouble() * 10000) + principal;

            Console.WriteLine("Starting Pricipal " + principal);
            Console.WriteLine("Desired Pricipal " + desiredPrincipal);

            Console.WriteLine("Interest Rate " + interest);
            Console.WriteLine("Tax Rate " + tax);

            Assert.AreEqual(CalculateYears(principal, interest, tax, desiredPrincipal), Investing.CalculateYears(principal, interest, tax, desiredPrincipal));

            Console.WriteLine("Years Required to accumulate Desired Pricipal " + CalculateYears(principal, interest, tax, desiredPrincipal));

        }

        private static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;
            double newPrincipal = 0;

            if (desiredPrincipal <= principal) return 0;
            else

                while (newPrincipal < desiredPrincipal)
                {
                    double interestBeforeTax = (principal * interest);
                    double interestAfterTax = interestBeforeTax - (interestBeforeTax * tax);
                    newPrincipal = (principal + interestAfterTax);
                    principal = newPrincipal;
                    years++;
                }

            return years;
        }
    }
}
