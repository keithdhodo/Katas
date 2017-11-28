using Kata.November2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class GaussTests
    {
        private static IEnumerable<TestCaseData> GaussTestCases
        {
            get
            {
                yield return new TestCaseData(100L).Returns(5050L);
                yield return new TestCaseData(300L).Returns(45150L);
                yield return new TestCaseData(50000L).Returns(1250025000L);
            }
        }

        [Test, TestCaseSource("GaussTestCases")]
        public long? Gauss_Range_ValidTests(long n) => Gauss.RangeSum(n);

        private static IEnumerable<TestCaseData> GaussErrorTestCases
        {
            get
            {
                yield return new TestCaseData(0).Returns(null).SetDescription("returns null if n is 0");
                yield return new TestCaseData(-10).Returns(null).SetDescription("returns null if n is less than 0");
            }
        }

        [Test, TestCaseSource("GaussErrorTestCases")]
        public long? Gauss_Range_ErrorTests(long n) => Gauss.RangeSum(n);

        private static Random rnd = new Random();

        private static long? GaussSolution(long n)
        {
            // Error handling
            if (n < 1) { return null; }

            // Triangular Number Formula:
            // https://en.wikipedia.org/wiki/Triangular_number
            return (n) * (n + 1) / 2;
        }

        [Test]
        public void Gauss_Range_RandomTest()
        {
            const int Tests = 100;
            const int MinValue = -2000000;
            const int MaxValue = int.MaxValue / 6;

            for (int i = 0; i < Tests; ++i)
            {
                long n = rnd.Next(MinValue, MaxValue + 1);

                long? expected = GaussSolution(n);
                long? actual = Gauss.RangeSum(n);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
