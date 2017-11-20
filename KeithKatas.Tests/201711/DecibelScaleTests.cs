using Kata.November2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class DecibelScaleTests
    {
        public static class Solution
        {
            public static double DbScale(double intensity) =>
              10 * Math.Log10(intensity / 1e-12);
        }

        [TestFixture]
        public class BasicTest
        {
            private static IEnumerable<TestCaseData> DecibelScale_TestCases
            {
                get
                {
                    yield return new TestCaseData(1e-12).Returns(0);
                    yield return new TestCaseData(1e-9).Returns(30);
                    yield return new TestCaseData(1e-5).Returns(70);
                    yield return new TestCaseData(10).Returns(130);
                    yield return new TestCaseData(100).Returns(140);
                    yield return new TestCaseData(10000).Returns(160);
                    yield return new TestCaseData(2.48794569 * 1e+173).Returns(1854);
                }
            }

            [Test, TestCaseSource("DecibelScale_TestCases")]
            public double Test(double intensity) =>
              Math.Round(DecibelScale.DbScale(intensity), MidpointRounding.AwayFromZero);
        }

        [TestFixture]
        public class RandomTest
        {
            private static IEnumerable<TestCaseData> DecibelScale_TestCases
            {
                get
                {
                    const int Tests = 100;
                    Random rnd = new Random();

                    for (int i = 0; i < Tests; ++i)
                    {
                        double intensity = rnd.NextDouble() * (1e-9 - 1e-12) + 1e-12;
                        double expected = Math.Round(Solution.DbScale(intensity));

                        yield return new TestCaseData(intensity).Returns(expected);
                    }
                }
            }

            [Test, TestCaseSource("DecibelScale_TestCases")]
            public double Test(double intensity) =>
              Math.Round(DecibelScale.DbScale(intensity), MidpointRounding.AwayFromZero);
        }
    }
}
