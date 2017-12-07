using Kata.December2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class InvertValueTests
    {
        [Test]
        public void InvertValue_InvertValues_BasicTests()
        {
            Assert.AreEqual(new int[] { -1, -2, -3, -4, -5 }, InvertValue.InvertValues(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -1, 2, -3, 4, -5 }, InvertValue.InvertValues(new int[] { 1, -2, 3, -4, 5 }));
            Assert.AreEqual(new int[] { }, InvertValue.InvertValues(new int[] { }));
            Assert.AreEqual(new int[] { 0 }, InvertValue.InvertValues(new int[] { 0 }));
        }

        [Test]
        public void InvertValue_InvertValues_RandomTests()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                var results = Enumerable.Range(0, rand.Next(100))
                        .Select(r => rand.Next(10))
                        .ToArray();

                Assert.AreEqual(Solve(results), InvertValue.InvertValues(results));
            }
        }

        private int[] Solve(int[] input)
        {
            return input.Select(n => -n).ToArray();
        }
    }
}
