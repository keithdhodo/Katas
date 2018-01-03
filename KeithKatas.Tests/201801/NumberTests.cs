using KeithKatas.January2018;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class NumberTests
    {
        [Test]
        public void Number_NumberToString_Test()
        {
            Assert.AreEqual("67", Number.ToString(67));
            Assert.AreEqual("79585", Number.ToString(79585));
            Assert.AreEqual("3", Number.ToString(1 + 2));
            Assert.AreEqual("-1", Number.ToString(1 - 2));
        }

        private static Random rnd = new Random();

        [Test]
        public void Number_NumberToString_RandomTests()
        {
            for (int i = 0; i < 100; ++i)
            {
                int num = rnd.Next(-1000, 1001);
                Assert.AreEqual("" + num, Number.ToString(num));
            }
        }
    }
}
