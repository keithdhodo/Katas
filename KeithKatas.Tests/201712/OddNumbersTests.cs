using KeithKatas.December2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class OddNumbersTests
    {
        [Test]
        public void OddNumbers_OddCount_Test()
        {
            Assert.AreEqual(7, OddNumbers.OddCount(15));
            Assert.AreEqual(7511, OddNumbers.OddCount(15023));
        }

        [Test]
        public void OddNumbers_OddCount_RandomTest()
        {
            Random rnd = new Random();

            for (int i = 0; i < 100; ++i)
            {
                // some very very poor ulong generator
                ulong n = ((ulong)rnd.Next() << rnd.Next(0, 31)) + (ulong)rnd.Next();

                Assert.AreEqual(n / 2, OddNumbers.OddCount(n));
            }
        }
    }
}
