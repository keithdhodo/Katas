using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Sandbox
{
    [TestClass]
    public class ReachMeAndSumMyDigitsTests
    {
        private static void testing(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReachMeAndSumMyDigitsTestsTest1()
        {
            Console.WriteLine("Basic Tests SumDigNthTerm");
            testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 6), 10);
            testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 15), 10);
            testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 50), 9);
            testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 78), 10);
            testing(ReachMeAndSumMyDigits.SumDigNthTerm(10, new long[] { 2, 1, 3 }, 157), 7);
        }
    }
}
