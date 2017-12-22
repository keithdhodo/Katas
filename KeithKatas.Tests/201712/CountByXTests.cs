using KeithKatas.December2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class CountByXTests
    {
        [Test]
        public static void CountByX_CountBy_CountBy1()
        {
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, CountByX.CountBy(1, 5), "Array does not match");
        }

        [Test]
        public static void CountByX_CountBy_CountBy2()
        {
            Assert.AreEqual(new int[] { 2, 4, 6, 8, 10 }, CountByX.CountBy(2, 5), "Array does not match");
        }
        [Test]
        public static void CountBy3()
        {
            Assert.AreEqual(new int[] { 3, 6, 9, 12, 15, 18, 21 }, CountByX.CountBy(3, 7), "Array does not match");
        }

        [Test]
        public static void CountBy50()
        {
            Assert.AreEqual(new int[] { 50, 100, 150, 200, 250 }, CountByX.CountBy(50, 5), "Array does not match");
        }

        [Test]
        public static void CountBy100()
        {
            Assert.AreEqual(new int[] { 100, 200, 300, 400, 500, 600 }, CountByX.CountBy(100, 6), "Array does not match");
        }

        [Test]
        public static void Test()
        {
            Random r = new Random();
            for (int k = 0; k < 20; k++)
            {
                int x = r.Next(1, 100);
                int n = r.Next(1, 20);
                Assert.AreEqual(Solve(x, n), CountByX.CountBy(x, n), "Did not work for this random test");
            }
        }

        private static int[] Solve(int x, int n)
        {
            int[] z = new int[n];
            for (int i = 0; i < n; i++)
                z[i] = (i + 1) * x;
            return z;
        }
    }
}
