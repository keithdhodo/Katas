using Kata.November2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class FakeBinaryTests
    {
        [Test]
        public void FakeBinary_ConvertToFakeBinary_BasicTests()
        {
            Assert.AreEqual("01011110001100111", FakeBinary.ConvertToFakeBinary("45385593107843568"));
            Assert.AreEqual("101000111101101", FakeBinary.ConvertToFakeBinary("509321967506747"));
            Assert.AreEqual("011011110000101010000011011", FakeBinary.ConvertToFakeBinary("366058562030849490134388085"));
            Assert.AreEqual("01111100", FakeBinary.ConvertToFakeBinary("15889923"));
            Assert.AreEqual("100111001111", FakeBinary.ConvertToFakeBinary("800857237867"));
        }

        [Test]
        public void FakeBinary_ConvertToFakeBinary_RandomTests()
        {
            var rand = new Random();

            for (var i = 0; i < 100; i++)
            {
                var len = rand.Next(1, 30);

                var x = String.Concat(Enumerable.Range(0, len).Select(a => rand.Next(0, 10).ToString()).ToArray());

                var expected = string.Concat(x.Select(a => a < '5' ? "0" : "1")); ;
                Assert.AreEqual(expected, FakeBinary.ConvertToFakeBinary(x));
            }
        }
    }
}
