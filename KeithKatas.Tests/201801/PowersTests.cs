using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Linq;
using System.Numerics;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class PowersTests
    {
        [Test]
        public void Powers_PowersOfTwo_BasicTests()
        {
            Assert.AreEqual(new BigInteger[] { 1 }, Powers.PowersOfTwo(0));
            Assert.AreEqual(new BigInteger[] { 1, 2 }, Powers.PowersOfTwo(1));
            Assert.AreEqual(new BigInteger[] { 1, 2, 4, 8, 16 }, Powers.PowersOfTwo(4));
        }

        [Test]
        public void Powers_PowersOfTwo_RandomTests()
        {
            var rand = new Random();

            Func<int, BigInteger[]> myPowersOfTwo = delegate (int n)
            {
                return Enumerable.Range(0, n + 1).Select(a => BigInteger.Pow(2, a)).ToArray();
            };

            var shuffle = Enumerable.Range(0, 201).OrderBy(a => rand.Next(-1, 2));

            shuffle.ToList().ForEach(n =>
            {
                Assert.AreEqual(myPowersOfTwo(n), Powers.PowersOfTwo(n));
            });
        }
    }
}
