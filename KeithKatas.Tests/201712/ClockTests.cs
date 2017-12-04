using Kata.December2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class ClockTests
    {
        [Test]
        public void Clock_Past_Test()
        {
            Assert.AreEqual(61000, Clock.Past(0, 1, 1));
        }

        [Test]
        public void Clock_Past_RandomTests()
        {
            Random r = new Random();

            for (int d = 0; d < 100; d++)
            {
                int i = r.Next(50);
                int j = r.Next(50);
                int s = r.Next(50);
                Assert.AreEqual(Past(i, j, s), Clock.Past(i, j, s), "Failed at Past(" + i + "," + j + "," + s + ")");
            }
        }

        public int Past(int h, int m, int s)
        {
            return (h * 60 + m) * 60000 + s * 1000;
        }
    }
}
