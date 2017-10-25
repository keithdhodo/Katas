using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata.August2016;

namespace Sandbox._201608
{
    [TestClass]
    public class GreatestCommonFactorialTests
    {
        [TestMethod]
        public void GreatestCommonFactorial1()
        {
            Assert.AreEqual(4, GreatestCommonFactorial.FindGCF(8, 20));
            Assert.AreEqual(1, GreatestCommonFactorial.FindGCF(5, 13));
            Assert.AreEqual(100, GreatestCommonFactorial.FindGCF(100, 100));
        }

        [TestMethod]
        public void GreatestCommonFactorialRandomTests()
        {
            var rand = new Random();

            Func<int, int, int> myFindGCF = null;

            myFindGCF = delegate (int num1, int num2)
            {
                return num2 == 0 ? num1 : myFindGCF(num2, num1 % num2);
            };

            for (int i = 0; i < 25; i++)
            {
                int n = rand.Next(0, 10000);
                int o = rand.Next(0, 10000);
                Assert.AreEqual(myFindGCF(n, o), GreatestCommonFactorial.FindGCF(n, o));
            }
        }
    }
}
